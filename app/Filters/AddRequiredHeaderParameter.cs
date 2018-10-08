
using Microsoft.AspNetCore.JsonPatch.Operations;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace DataAccessService.API.Filters
{
    public class AddRequiredHeaderParameter :  IOperationFilter
    {
        
        public void Apply(Swashbuckle.AspNetCore.Swagger.Operation operation, OperationFilterContext context)
        {
            if (operation.Parameters == null)
                operation.Parameters = new List<IParameter>();
            operation.Parameters.Add(new NonBodyParameter()
            {
                Name="AccessToken"
            });
        }
    }
}
