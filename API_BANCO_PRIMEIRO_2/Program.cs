using API_BANCO_PRIMEIRO_2.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<EscolaContext>(options =>

        options.UseSqlServer(builder.Configuration.GetConnectionString("Pizzaria"))); //  //Diz o que o banco é SQL SERVER e busca a connection string chamada "Escola".
                                                                                    //dentro da secao ConnectionStrings do appsettings.json


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
