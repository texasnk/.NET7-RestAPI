using RestWithASPNETUdemy.Model.Context;
using Microsoft.EntityFrameworkCore;
using RestWithASPNETUdemy.Business;
using RestWithASPNETUdemy.Business.Implementations;
using RestWithASPNETUdemy.Repository;
using RestWithASPNETUdemy.Repository.Implementations;
using Serilog;
using Microsoft.EntityFrameworkCore.Migrations;
using EvolveDb;

namespace RestWithASPNETUdemy
{
    public class Program
    {      
        public static IWebHostEnvironment environment { get; }
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //
            var Environment = environment;
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();
            //
     
            
            // Add services to the container.

            builder.Services.AddControllers();

            //
            builder.Services.AddApiVersioning();
            var connection = builder.Configuration["MySqlC onnection:MysqlConnectionString"];
            builder.Services.AddDbContext<MySQLContext>(options => options.UseMySql
            (connection, new MySqlServerVersion(new Version(8, 0, 25))));
            if (Environment.IsDevelopment())
            {
                MigrationDataBase(connection);
            }

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

        private static void MigrationDataBase(string connection)
        {
            try
            {
                var evolveConnection = new MySql.Data.MySqlClient.MySqlConnection(connection);
                var evolve = new Evolve(evolveConnection, msg => Log.Information(msg))
                {
                    Locations = new List<string> { "db/migrations", "db/dataset" }, IsEraseDisabled = true,
                };
                evolve.Migrate();
            }
            catch (Exception ex)
            {
                Log.Error("Database migration failed" + ex);
                throw;
            }
        }
    }
}