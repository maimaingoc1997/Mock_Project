using ContactManagementAPI.Data;
using ContactManagementAPI.Models;
using ContactManagementAPI.Repositories;
using ContactManagementAPI.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
var serverVersion = new MySqlServerVersion(new Version(8, 0, 23));

builder.Services.AddDbContext<ContactDbContext>(options =>
    options.UseMySql(connectionString, serverVersion));

builder.Services.AddScoped<IContactRepository, ContactRepository>();
builder.Services.AddScoped<IManagerNameRepository, ManagerNameRepository>();
builder.Services.AddScoped<ContactService>();
builder.Services.AddScoped<ManagerNameService>();
builder.Services.AddControllers();
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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();