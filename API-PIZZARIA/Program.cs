using API_PIZZARIA.Contexts;
using API_PIZZARIA.Interface;
using API_PIZZARIA.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<PizzariaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Pizzaria")));

builder.Services.AddControllers();

builder.Services.AddScoped<IClienteRepository, ClienteRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGet("/api/Pizza", (PizzariaContext db) => db.Pizza.ToList());

app.Run();
