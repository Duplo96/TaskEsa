
using Microsoft.EntityFrameworkCore;
using Task_Esa.Models;
using Task_Esa.Repos;
using Task_Esa.Services;

namespace Task_Esa
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            builder.Services.AddDbContext<EsaContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddScoped <OggettoCelesteRepo>();

            builder.Services.AddScoped<OggettoCelesteService>();
            builder.Services.AddScoped<SistemaRepo>();
            builder.Services.AddScoped<SistemaService>();









            var app = builder.Build();

            app.UseCors(builder =>
                builder
                .WithOrigins("*")
                .AllowAnyMethod()
                .AllowAnyHeader());

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
