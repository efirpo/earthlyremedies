
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
  public class RatingsController : ControllerBase
  {
    private EarthlyRemediesContext _db;

    public RatingsController(EarthlyRemediesContext db)
    {
      _db = db;
    }

    // POST api/Remedies
    [HttpPost]
    public void Post([FromBody] Rating rating)
    {
      _db.Ratings.Add(rating);
      _db.SaveChanges();
    }

    // [HttpPost]
    // public void Post([FromBody] Rating rating)
    // {
    //   _db.Ratings.Add(rating);
    //   _db.SaveChanges();
    // }
  }
}