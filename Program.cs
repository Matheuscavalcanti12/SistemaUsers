using Contest;
using rotas;
using MySql.Data.MySqlClient;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// Add services
builder.Services.AddEndpointsApiExplorer();


var app = builder.Build();
app.UseCors();
app.rotas();
app.rotasUsuario();
app.rotasContest();


app.Run();

// hoje aprendi que posso criar classes com atributos e metodos e chamala no meu programa, ou melhor, na minha API
//Criando noção em padrâo MVC
//aprendi que posso colocar minha api em uma classe na m