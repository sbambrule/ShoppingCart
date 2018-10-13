using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DataAccessService.API.Filters;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using Newtonsoft.Json.Serialization;
using Swashbuckle.AspNetCore.Swagger;

namespace app
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }


    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.Configure<CookiePolicyOptions>(options =>
      {
        // This lambda determines whether user consent for non-essential cookies is needed for a given request.
        options.CheckConsentNeeded = context => true;
        options.MinimumSameSitePolicy = SameSiteMode.None;
      });
      services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                .AddJsonOptions(o => o.SerializerSettings.ContractResolver = new DefaultContractResolver());

      services.AddSwaggerGen(c =>
      {
        c.SwaggerDoc("v1", new Info
        {
          Title = "DataAccess Service",
          Version = "v1",
        });
        c.DescribeAllEnumsAsStrings();
        c.OperationFilter<AddRequiredHeaderParameter>();
      });
      services.ConfigureSwaggerGen(c =>
      {
        var appbase = PlatformServices.Default.Application.ApplicationBasePath;
        var swaggerFilepath = Configuration.GetSection("AppSettings:SwaggerDocFilePath");
        c.IncludeXmlComments(Path.Combine(appbase, swaggerFilepath.Value));
        c.OperationFilter<AddRequiredHeaderParameter>();
      });
       
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      else
      {
        app.UseExceptionHandler("/Home/Error");
        app.UseHsts();
      }

      app.UseHttpsRedirection();
      app.UseStaticFiles();
      app.UseCookiePolicy();

      // Shows UseCors with named policy.
      app.UseCors("AllowSpecificOrigin");

      app.UseMvcWithDefaultRoute();
      app.UseSwagger(c =>
      {
        c.RouteTemplate = "swagger/{documentName}/swagger.json";
      });
      app.UseSwaggerUI(c =>
      {
        c.SwaggerEndpoint("v1/swagger.json", "DataAccessService.API");
      });
    }
  }
}
