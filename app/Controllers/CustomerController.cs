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
        public   IActionResult GetCustomerByIdAsync(ulong CustomerId)
        {

            


            return Ok(new GetCustomerResponse() {  });
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
    }   
    
}
