using Microsoft.EntityFrameworkCore;
using WebStructure.WebApp._2_Services.ServiceInterface;
using WebStructure.WebApp._2_Services.ServiceLogic;
using WebStructure.WebApp._3_BusinessLogic.BusinessLogic;
using WebStructure.WebApp._3_BusinessLogic.BusinessLogicInterface;
using WebStructure.WebApp._4_DataAcess;
using WebStructure.WebApp._4_DataAcess.IRepository;
using WebStructure.WebApp._4_DataAcess.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<ICars,CarsService>();
builder.Services.AddTransient<ICarsBusinessLogic,CarsBusinessLogic>();
builder.Services.AddTransient<ICarsRepository,CarsRepository>();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<Context>(x => x.UseSqlServer(connectionString));


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
