namespace RotasModels;

//criar classe
 public class RotasModel
{
    public RotasModel(string usuario)
    {
        this.usuario = usuario;
    }

    //criação do metodo
    public RotasModel(string? usuario, string? senha)
    {
        Id = Guid.NewGuid();
        this.usuario = usuario;
        this.senha = senha;
    }
    //Atualização instantânea de ID
    //Atributos
    public Guid Id { get; init; }
    public string? usuario { get; set; }
    public string? senha { get; set; }
}