using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using EarthlyRemedies.Models;

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
    [HttpGet]
    public ActionResult<IEnumerable<Remedy>> Get()
    {
      return _db.Remedies.ToList();
    }

    // POST api/Remedies
    [HttpPost]
    public void Post([FromBody] Remedy remedy)
    {
      _db.Remedies.Add(remedy);
      _db.SaveChanges();
    }
  }
}