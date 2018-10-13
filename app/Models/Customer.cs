using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessService.API.Models
{
  public class Customer
  {
    public int IdCustomer { get; set; }
    public string CustomerFullName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
  }
}
