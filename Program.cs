using Microsoft.EntityFrameworkCore;
using DotNetBot.Data;
using DotNetBot.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();

// Database connection with PostgreSQL
AppDbContextFactory.ConfigureServices(
    builder.Services, builder.Configuration.GetConnectionString("DefaultConnection")
);


var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();
app.Run();
