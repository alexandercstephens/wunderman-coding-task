using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Text.Json;

namespace WundermanCodingTask.WebApplication
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
            // Configure gizmos to be retrieved via HTTP, as specified in the requirements. 
            services.AddScoped<IGizmoResource, HttpJsonGizmoResource>(
                _ => new HttpJsonGizmoResource(
                    // Configure URL to be localhost URL pointing to the API project, served by IIS Express.
                    // Typically, in QA/prod, this would be configured to point to a real URL read from a configuration file.
                    // In development, this would point to a localhost URL (like it is here), or one might use a DummyGizmoResource for some development instead.
                    "http://localhost:64829/gizmos",
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
                    )
                );

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
