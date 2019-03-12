using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Class031119
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddMvc();
            services.AddMvcCore().AddJsonFormatters();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Middleware for static files
            //app.UseDefaultFiles();
            app.UseStaticFiles();

            // Default /(controller)/(action)
            app.UseMvcWithDefaultRoute();

            //app.UseMvc();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("No page found." + "\n");
                await context.Response.WriteAsync("URL: " + context.Request.Path + "\n");
                await context.Response.WriteAsync(System.Diagnostics.Process.GetCurrentProcess().ProcessName + "\n");
                //if (context.Request.Path == "/details")
                //{
                //    await context.Response.WriteAsync("Welcome to the details page." + "\n");
                //}
            });
        }
    }
}
