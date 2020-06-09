using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using EarthlyRemedies.Services;
using EarthlyRemedies.Models;

namespace EarthlyRemedies.Controllers
{
  [Authorize]
  [ApiController]
  [Route("[controller]")]
  public class UsersController : ControllerBase
  {

    private EarthlyRemediesContext _db;
    private IUserService _userService;

    public UsersController(EarthlyRemediesContext db, IUserService userService)
    {
      _db = db;
      _userService = userService;
    }

    [AllowAnonymous]
    [HttpPost("authenticate")]
    public IActionResult Authenticate([FromBody] User userParam)
    {
      var user = _userService.Authenticate(userParam.Username, userParam.Password);

      if (user == null)
      {
        return BadRequest(new { message = "Username or password is incorrect" });
      }
      return Ok(user);
    }

    [AllowAnonymous]
    [HttpGet]
    public IActionResult GetAll()
    {
      var users = _userService.GetAll();
      return Ok(users);
    }
  }
}
