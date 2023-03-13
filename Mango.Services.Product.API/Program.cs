
using AutoMapper;
using Mango.Services.Product.API.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.Product.API
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

            builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

            //Use SQL_Server
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            ////using mapping
            //IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();//a tut sozdaem mapping
            //builder.Services.AddSingleton(mapper);//eto toje dla mappinga
            //builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());//eto dla mappinga
            //builder.Services.AddScoped<IProductRepository, ProductRepository>();//etot punkt dla repo

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