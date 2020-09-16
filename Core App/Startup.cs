using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Core_App
{
    public class Startup
    {
        private readonly IConfiguration _config;

        public Startup(IConfiguration config)
        {
            _config = config;
        }

        // Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add MVC services 
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }

        // Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                // Important to be registered early in the request pipeline.
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            // Register MVC middleware => Important to be registered after UseStaticFile middleware
            app.UseMvcWithDefaultRoute();

            app.Run(async context =>
            {
                await context.Response.WriteAsync("response from last middleware.");
            });
        }
    }
}
