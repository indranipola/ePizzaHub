using ePizzaHub.Core.Concrete;
using ePizzaHub.Core.Contracts;
using ePizzaHub.Infrastructure.Models;
using ePizzaHub.Repositories.Concrete;
using ePizzaHub.Repositories.Contract;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ePizzaHubContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseConnection"));

});
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IRoleRepository, RoleRepository>();


builder.Services.AddTransient<Iuserservice, UserService>();

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
