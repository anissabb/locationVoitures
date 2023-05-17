using Location_voiture_COMMON.Repositories;
using DAL=Location_voitures_DAL.Entities;
using BLL=Location_voitures_BLL.Entites;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DALServ=Location_voitures_DAL.Services;
using BLLServ=Location_voitures_BLL.Services;
namespace Location_voitures
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
            services.AddControllersWithViews();
            services.AddScoped<IClientRepository<DAL.Client, int>, DALServ.ClientService>();
            services.AddScoped<IClientRepository<BLL.Client, int>,BLLServ.ClientService>();
            
            services.AddScoped<IVoitureRepository<DAL.Voiture, int>,DALServ.VoitureService>();
            services.AddScoped<IVoitureRepository<BLL.Voiture, int>,BLLServ.VoitureService>();
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
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "CompteClient",
                    pattern: "{controller=Client}/{action=Index}");
            });
        }
    }
}
