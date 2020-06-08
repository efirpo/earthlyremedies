using System.Collections.Generic;
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

    // GET api/remedies/#
    [HttpGet("{id}")]
    public ActionResult<Remedy> Get(int id)
    {
      return _db.Remedies.FirstOrDefault(entry => entry.RemedyId == id);
    }

    //PUT api/remedies/#
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Remedy remedy)
    {
      remedy.RemedyId = id;
      _db.Entry(remedy).State = EntityState.Modified;
      _db.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var remedyToDelete = _db.Remedies.FirstOrDefault(entry => entry.RemedyId == id);
      _db.Remedies.Remove(remedyToDelete);
      _db.SaveChanges();
    }

    // GET api/Remedies
    [HttpGet]
    public ActionResult<IEnumerable<Remedy>> Get(string name, string details, string ailment, string category, string ingredients, int userId)
    {
      var query = _db.Remedies.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (details != null)
      {
        query = query.Where(entry => entry.Details.Contains(details));
      }

      if (details != null)
      {
        query = query.Where(entry => entry.Ingredients.Contains(ingredients));
      }

      if (ailment != null)
      {
        query = query.Where(entry => entry.Ailment == ailment);
      }

      if (category != null)
      {
        query = query.Where(entry => entry.Category == category);
      }

      if (userId != 0)
      {
        query = query.Where(entry => entry.UserId == userId);
      }

      return query.ToList();
    }
  }
}
