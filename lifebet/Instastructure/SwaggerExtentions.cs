using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.IO;

namespace lifebet.Instastructure
{
    public static class SwaggerExtentions
    {
        public static void AddSwagger(this IServiceCollection services, IConfiguration configuration)
        {
            var config = configuration.GetSection("Swagger").Get<SwaggerOptions>();

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc(config.Version, new OpenApiInfo
                {
                    Title = config.Title,
                    Version = config.Version,
                    Description = config.Description
                });

                var xmlPath = Path.Combine(AppContext.BaseDirectory, "lifebet.xml");
                // options.IncludeXmlComments(xmlPath);
            });
        }

        public static void UseSwagger(this IApplicationBuilder app, IConfiguration configuration)
        {
            var config = configuration.GetSection("Swagger").Get<SwaggerOptions>();

            app.UseSwagger(c => c.RouteTemplate = $"{config.Route}/{{documentName}}/swagger.json");

            app.UseSwaggerUI(c =>
            {
                c.RoutePrefix = $"{config.Route}";
                c.SwaggerEndpoint($"{config.Route}/v1/swagger.json", config.Title);
            });
        }
    }
}
