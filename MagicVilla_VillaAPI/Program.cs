using MagicVilla_VillaAPI.Logging;
using MagicVilla_VillaAPI.Data;
using Microsoft.EntityFrameworkCore;
using MagicVilla_VillaAPI.Repository.IRepository;
using MagicVilla_VillaAPI.Repository;
using Microsoft.Data.SqlClient;
namespace MagicVilla_VillaAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<ApplicationDbContext>(option => 
            {
                option.UseSqlServer(builder.Configuration.GetConnectionString("MagicVillaConnection"));
            });
            

            builder.Services.AddScoped<IVillaRepository, VillaRepository>();

            builder.Services.AddScoped<IVillaNumberRepository, VillaNumberRepository>();

            builder.Services.AddAutoMapper(typeof(MappingConfig));

            builder.Services.AddControllers(option => { option.ReturnHttpNotAcceptable = true; }).AddNewtonsoftJson().AddXmlDataContractSerializerFormatters(); // we are talking about the fact that it can be any format json, xml... that the user has configured
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
