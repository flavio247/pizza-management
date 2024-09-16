using Microsoft.EntityFrameworkCore;
using pizza_management.Models;
using pizza_management.Patterns;
using pizza_management.Persistance;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<PizzaContext>(opt =>
    opt.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=pizza-management;Integrated Security=SSPI;Persist Security Info=False;TrustServerCertificate=True"));
builder.Services.AddTransient<IOrderService,OrderService>();
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
