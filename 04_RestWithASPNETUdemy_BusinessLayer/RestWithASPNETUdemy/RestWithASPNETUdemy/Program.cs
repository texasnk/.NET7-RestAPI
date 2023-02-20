using RestWithASPNETUdemy.Model.Context;
using Microsoft.EntityFrameworkCore;
using RestWithASPNETUdemy.Business;
using RestWithASPNETUdemy.Business.Implementations;
using RestWithASPNETUdemy.Repository;
using RestWithASPNETUdemy.Repository.Implementations;

namespace RestWithASPNETUdemy
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            //
            builder.Services.AddApiVersioning();

            var connection = builder.Configuration["MySqlConnection:MysqlConnectionString"];
            builder.Services.AddDbContext<MySQLContext>(options => options.UseMySql
            (connection, new MySqlServerVersion(new Version(8, 0, 25))));

            //Dependency injection
            builder.Services.AddScoped<IPersonBusiness, PersonBusinessImplementation>();
            builder.Services.AddScoped<IPersonRepository, PersonRepositoryImplementation>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}