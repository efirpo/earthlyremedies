using System.Collections.Generic;
using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using EarthlyRemedies.Models;
using Microsoft.EntityFrameworkCore;


namespace EarthlyRemedies.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class RemediesController : ControllerBase
  {
    private EarthlyRemediesContext _db;

    public RemediesController(EarthlyRemediesContext db)
    {
      _db = db;
    }

    // GET api/Remedies
    // [HttpGet]
    // public ActionResult<IEnumerable<Remedy>> Get()
    // {
    //   return _db.Remedies.ToList();
    // }

    // POST api/Remedies
    [HttpPost]
    public void Post([FromBody] Remedy remedy)
    {
      _db.Remedies.Add(remedy);
      _db.SaveChanges();
    }

    [HttpGet("{id}")]

    public ActionResult<Remedy> Get(int id)
    {
      var thisRemedy = _db.Remedies.FirstOrDefault(remedy => remedy.RemedyId == id);
      return thisRemedy;
    }


    //PUT api/remedies/userId/remedyId
    [HttpPut("{id}")]
    public void Put(int userId, int id, [FromBody] Remedy remedy)
    {
      remedy.RemedyId = id;
      if (remedy.UserId == userId)
      {
        _db.Entry(remedy).State = EntityState.Modified;
        _db.SaveChanges();
      }
    }

    //http://localhost:5000/api/remedies/1/9
    [HttpDelete("{id}")]
    public void Delete(int id, int userId)
    {
      var remedyToDelete = _db.Remedies.FirstOrDefault(entry => entry.RemedyId == id);
      _db.Remedies.Remove(remedyToDelete);
      _db.SaveChanges();
    }

    [HttpGet]
    //Search GET
    public ActionResult<IEnumerable<Remedy>> Get(string name, string details, string ailment, string ingredients, int userId)
    {

      var query = _db.Remedies
      .Include(remedy => remedy.Categories)
      .ThenInclude(join => join.Category)
      .AsQueryable();
      foreach (Remedy remedy in query)
      {
        foreach (var join in remedy.Categories)
        {
          Console.WriteLine("\n\n\n\n\n\n" + join.Category.Name + "\n\n\n\n\n");
        };
      };

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (details != null)
      {
        query = query.Where(entry => entry.Details.Contains(details));
      }

      if (ingredients != null)
      {
        query = query.Where(entry => entry.Ingredients.Contains(ingredients));
      }

      if (ailment != null)
      {
        query = query.Where(entry => entry.Ailment == ailment);
      }

      // if (category != null)
      // {
      //   query = query.Where(entry => entry.Categories.Contains(category));
      // }

      if (userId != 0)
      {
        query = query.Where(entry => entry.UserId == userId);
      }
      return query.ToList();
    }
  }
}
