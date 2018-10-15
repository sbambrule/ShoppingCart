using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Auth0.AuthenticationApi;
using Auth0.AuthenticationApi.Models;
using DataAccessService.API.Filters;
using DataAccessService.API.Models;
using DataAccessService.API.Response;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace DataAccessService.API.Controllers
{
  /// <summary>
  /// 
  /// </summary>
  [Route("[controller]")]
  [ApiExceptionFilterAttribute]
  [EnableCors("AllowSpecificOrigin")]
  public class CustomerController : Controller
  {
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    [HttpGet("GetCustomerById")]
    public IActionResult GetCustomerById(ulong CustomerId)
    {
      return Ok(new GetCustomerResponse() { });
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    [HttpGet("GetCustomerSearch")]
    public IActionResult GetCustomerSearch()
    {
      return Ok(new GetCustomerSearchResponse() { });
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="customer"></param>
    /// <returns></returns>
    [HttpPost("InsertCustomer")]
    public IActionResult InsertCustomer(Customer customer)
    {

      return Ok(new InsertCustomerResponse() { });
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="customer"></param>
    /// <returns></returns>
    [HttpPost("UpdateCustomer")]
    public IActionResult UpdateCustomer(Customer customer)
    {

      return Ok(new UpdateCustomerResponse() { });
    }
  }
}
