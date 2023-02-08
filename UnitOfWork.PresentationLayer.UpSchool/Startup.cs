using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitOfWork.BusisnessLayer.UpSchool.Abstract;
using UnitOfWork.BusisnessLayer.UpSchool.Concrete;
using UnitOfWork.DataAccessLayer.UpSchool.Abstract;
using UnitOfWork.DataAccessLayer.UpSchool.Concrete;
using UnitOfWork.DataAccessLayer.UpSchool.EntityFramework;
using UnitOfWork.DataAccessLayer.UpSchool.UnitOfWork;

namespace UnitOfWork.PresentationLayer.UpSchool
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
            services.AddScoped<IAccountDAL, EFAccountDAL>();
            services.AddScoped<IAccountService, AccountManager>();

            services.AddScoped<IProcessDetailDAL, EFProcessDetailDAL>();
            services.AddScoped<IProcessDetailService, ProcessDetailManager>();

            services.AddScoped<IUnitOfWorkDAL, UnitOfWorkDAL>();

            services.AddDbContext<Context>();

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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
