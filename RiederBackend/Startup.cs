using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
//using Microsoft.IdentityModel.Tokens;
using RiederBackend.Helpers;
using RiederBackend.Model;
using RiederBackend.ServiceInterface;
using RiederBackend.Services;
using AutoMapper;

namespace RiederBackend
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
            services.AddControllers();
            //-------------------
            //services.AddCors();
            //--------------------
            services.AddDbContext<ApplicationDbContext>(opt=>opt.UseSqlServer
                (Configuration.GetConnectionString("DefaultConnection")));
            //add automapper
            services.AddAutoMapper(typeof(Startup));

            //configure DI for application services 
            //  services.AddScoped<IUserServices, UserServices>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            //add the authentication to the middleware

          //  app.UseAuthentication();
            //--------------------end

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
