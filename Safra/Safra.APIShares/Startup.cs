using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Carter;
using Safra.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Microsoft.Extensions.Hosting;

namespace Safra.APIShares
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Safra.APIShares", Version = "v1" });
            });

            services.AddCarter();
            const string Name = "DefaultConnection";
            services.AddDbContextPool<Context>(optios =>
            {                
                optios.UseSqlite(Configuration.GetConnectionString(Name));
            });

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(sw =>
                {
                    sw.RoutePrefix = "openapi/ui";
                    sw.SwaggerEndpoint("/swagger/v1/swagger.json", "Safra: Carter OpenAPI");
                });
            }
            
            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapCarter();
            });

            app.UseStaticFiles();
            app.UseCors();
        }
    }
}
