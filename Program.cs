using Contest;
using rotas;
var builder = WebApplication.CreateBuilder(args);
//uso de cors para permitir requisições do frontend
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy
            .WithOrigins(
                "http://127.0.0.1:5500",
                "http://localhost:5500"
            )
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

builder.Services.AddControllers();

var app = builder.Build();

//inicia o cors para permitir requisições do frontend
app.UseCors();

app.MapControllers();
//indispensavel para o funcionamento do sistema, é onde estão as rotas de cada controller
app.rotasUsuario();
app.rotasContest();
app.LoginRequest();
app.rotas();

app.Run();
