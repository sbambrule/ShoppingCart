using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessService.API.Filters;
using DataAccessService.API.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace app.Controllers
{
  [Route("[controller]")]
  [ApiExceptionFilterAttribute]
  public class LoginController : Controller
  {
    [HttpPost]
    [HttpPost("Login")]
    public ActionResult Login(IFormCollection collection)
    {
      return Ok(new LoginSession() { IsSuccess = true });
    }
  }
}
