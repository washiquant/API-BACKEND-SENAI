using EscolaAPI.Contexts;
using EscolaAPI.Interfaces;
using EscolaAPI.Repositories;
using Microsoft.EntityFrameworkCore;



// Add services to the container.


//Cria o "Construtor" da aplicacao.
//Ler o appsetting.json
//e prepara a lista de servicos que a API

var builder = WebApplication.CreateBuilder(args);

//PARTE 1 - REGISTRAR OS SERVICOS ( O QUE API VAI TER DE DISPONIVEL)

//HABILITA O USO DE CONTROLLER NA API
builder.Services.AddControllers();

//REGISTRA O ESCOLACONTEXT (A "PONTE" COM O BANCO) PARA A API PODER USA-LO
builder.Services.AddDbContext<EscolaContext>(options =>

    options.UseSqlServer(builder.Configuration.GetConnectionString("Escola")));

//Monta a aplicacao com tudoo que foi registrado acima.
//daqui pra baixo nao da mais pra registrar servicos

var app = builder.Build();

//NOVO : QUANDO ALGUEM PEDIR ICursoRepository, a API entrega uma instancia de CursoRepository
builder.Services.AddScoped<ICursoRepsitory, CursoRepository>();
//pate 2 --- O CAMINHO DE ADA REQUISICAO(PIPELINE) =====
app.UseHttpsRedirection(); //REDIRECIONA O USUARIO DE HTTP PARA HTTPS

app.UseAuthorization(); // VERIFICO AS PERMISSOES DE ACESSO ( VAMOS UTILIZAR PARA QUANDO TIVERMOS LOGIN)

app.MapControllers(); // API/CURSO - LIGA AS ROTAS DEFINIDAS NAS CONTROLLERS

app.MapGet("/api/cursos", (EscolaContext db) => db.Curso.ToList()); 

app.Run(); // LIGA A API E DEIXA ELA ESPERANDO AS REQUISICOES
