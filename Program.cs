using Contest;
using rotas;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy
            .WithOrigins("http://127.0.0.1:5500")
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseCors("Frontend");

app.MapControllers();

app.rotasUsuario();
app.rotasContest();
app.rotas();

app.Run();
// hoje aprendi que posso criar classes com atributos e metodos e chamala no meu programa, ou melhor, na minha API
//Criando noção em padrâo MVC
//aprendi que posso colocar minha api em uma classe na m