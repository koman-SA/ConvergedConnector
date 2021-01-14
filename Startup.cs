using ConvergedConnector.Data;
using ConvergedConnector.Data.Entities;
using ConvergedConnector.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.Text;

namespace ConvergedConnector
{

    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        private readonly IConfiguration _config;
        public Startup(IConfiguration config)
        {
            _config = config;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<PlatformContext>(cfg =>
            {
                cfg.UseSqlServer(_config.GetConnectionString("ConvergedConnectionString"));
            }
            );

            services.AddTransient<ConvergedSeeder>();








        }

        public static void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {


            app.UseStaticFiles();
            app.UseNodeModules();

            app.UseRouting();

            //app.UseEndpoints();

        }
    }
}

