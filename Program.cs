using Contest;
using rotas;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddCors(options =>
{
    options.AddPolicy("Frontend",
        policy =>
        {
            policy
                .WithOrigins("http://localhost:5500", "http://127.0.0.1:5500")
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