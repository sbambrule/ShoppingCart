﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Auth0.AuthenticationApi;
using Auth0.AuthenticationApi.Models;
using Common.Data.Model; 
using DataAccessService.API.Filters;
using DataAccessService.API.Response;
using Microsoft.AspNetCore.Mvc;

namespace DataAccessService.API.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("[controller]")]
    [ApiExceptionFilterAttribute]
    public class CustomerController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetCustomerById")]
        public   IActionResult GetCustomerByIdAsync(ulong CustomerId)
        {

            try
            {
             

            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
            }


            return Ok(new GetCustomerResponse() { Customer = new Customer() });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetCustomerSearch")]
        public IActionResult GetCustomerSearch()
        {
            return Ok(new GetCustomerSearchResponse() { Customers =new List<Customer>() });
        }
    }   
    
}