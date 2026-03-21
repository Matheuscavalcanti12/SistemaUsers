using Contest;
using rotas;
var builder = WebApplication.CreateBuilder(args);

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


app.UseCors();

app.MapControllers();

app.rotasUsuario();
app.rotasContest();
app.LoginRequest();
app.rotas();

app.Run();
