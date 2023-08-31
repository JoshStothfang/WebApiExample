using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApiExample.Data;

var builder = WebApplication.CreateBuilder(args);

//this tells which connection string to use
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DevDb") //get connections string from appsettings
    ?? throw new InvalidOperationException("Connection string 'DevDb' not found."))); //throws exception if it can't connect

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseCors(x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()); //allows any IP to talk to code (good for dev, bad for production)

app.UseAuthorization();

app.MapControllers();

app.Run();

