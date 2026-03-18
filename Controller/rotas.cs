using RotasModels;

namespace rotas;

public static class Rota
{
    public static void rotas(this WebApplication app)
    {
       //Busca dados
    app.MapGet(pattern:"/rotas", () => new RotasModel(usuario:"matheus" ));

    }
}