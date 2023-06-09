using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace P19
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSpaStaticFiles();
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }
        public void Configure(IApplicationBuilder app)
        {

            app.UseStaticFiles();
            app.UseMvc(

               r =>
               {
                   r.MapRoute(
                          name: "default",
                          template: "{controller=Default}/{action=Index}"
                          );
               });
        }
    }
}
