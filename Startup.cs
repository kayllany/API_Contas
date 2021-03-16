using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using Microsoft.EntityFrameworkCore;
using contasAPagar.Data;
using Swashbuckle.Swagger;

namespace contasAPagar
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

            services.AddDbContext<contasAPagarContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("contasAPagarContext")));

            //implementação do Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                new Microsoft.OpenApi.Models.OpenApiInfo()
                {

                    Title = "API Contas a pagar",
                    Contact = new Microsoft.OpenApi.Models.OpenApiContact()
                    {
                        Name = "Kayllany Paes Bicudo",
                        Url = new Uri("https://github.com/kayllany/API_Contas.git")
                    },
                    Description = "Primeira API criada com o ASP.NET Core"
                });

            });
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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI( c =>
            {
                 c.SwaggerEndpoint("/swagger/v1/swagger.json", "API Contas a pagar");
            });
        }

    }
}
