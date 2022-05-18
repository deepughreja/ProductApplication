using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProductApplication.Contract.Contracts;
using ProductApplication.DatabaseEntities;
using ProductApplication.ObjectMaps.ObjectMaps;
using ProductApplication.Repository.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IProductRepository, ProductRepository>();

var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MappingProfile());
});
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);




var connection = @"Data Source=LAPTOP-8I6BV57D;Initial Catalog=ProductDb;Integrated Security=True;";

//services.AddDbContext<app_DbContext>(options => options.UseSqlServer(connection));


builder.Services.AddDbContext<ProductContext>(options => options.UseSqlServer(connection));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//app.UseCors(MyAllowSpecificOrigins);

app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
