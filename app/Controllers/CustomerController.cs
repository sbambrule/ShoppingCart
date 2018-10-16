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
    [HttpPost("GetCustomerById")]
    public IActionResult GetCustomerById(ulong CustomerId)
    {
      return Ok(new GetCustomerResponse() { Customer = new Customer() { IdCustomer = 1, LastName = "Bambrule", FirstName = "Santosh" } });
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    [HttpPost("GetCustomerSearch")]
    public IActionResult GetCustomerSearch(Customer customer)
    {
      return Ok(new GetCustomerSearchResponse()
      {
        CustomerList = new List<Customer>(){
       new Customer() { IdCustomer = 1, LastName = "Bambrule", FirstName = "Santosh" },
       new Customer() { IdCustomer = 2, LastName = "Ydav", FirstName = "Raju" },
       new Customer() { IdCustomer = 3, LastName = "omkar", FirstName = "sharma" }
      }
      });
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="customer"></param>
    /// <returns></returns>
    [HttpPost("Add")]
    public IActionResult Add(Customer customer)
    {

      return Ok(new InsertCustomerResponse() { IsSuccess=true });
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="customer"></param>
    /// <returns></returns>
    [HttpPost("Update")]
    public IActionResult Update(Customer customer)
    {

      return Ok(new UpdateCustomerResponse() { IsSuccess = true });
    }
  }
}
