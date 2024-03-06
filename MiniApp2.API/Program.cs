
using Microsoft.OpenApi.Models;
using SharedLibrary.Configurations;
using SharedLibrary.Extensions;

namespace MiniApp2.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.Configure<CustomTokenOption>(builder.Configuration.GetSection("TokenOption"));
            var tokenOptions = builder.Configuration.GetSection("TokenOption").Get<CustomTokenOption>();

            builder.Services.AddCustomTokenAuth(tokenOptions);

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MiniApp2.API", Version = "v1" });
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MiniApp2.API v1"));
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
