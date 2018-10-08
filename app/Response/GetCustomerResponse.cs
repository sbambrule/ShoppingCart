using Common.Data.Model;
using Common.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessService.API.Response
{
    public class GetCustomerResponse :ResponseBase
    {
        public Customer Customer { get; set; }
    }
}
