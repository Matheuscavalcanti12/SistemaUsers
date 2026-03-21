
using MySql.Data.MySqlClient;


namespace Contest;

public static class RotasContest{
public static void rotasContest(this WebApplication app)
{
app.MapGet("/usuarios", () =>
{
   // variavel de url de conexao com o banco
   string conexao = "server=localhost;database=Login;user=root;password=;";
   using var conn = new  MySqlConnection(conexao);
   conn.Open();

   
   String sql = "SELECT * FROM usuario";
   // puxa a conexao e o comando sql
   using var cmd = new MySqlCommand(sql , conn);
   //Variavel que executa os comandos sql e guarda o resultado
   using var reader = cmd.ExecuteReader();

   List<Usuario> Lista = new List<Usuario>();
   while (reader.Read()){
      Usuario u = new Usuario();
      u.id = reader.GetInt32("id");
      u.email = reader.GetString("email");
      Lista.Add(u);
   }

   return Results.Ok(Lista);
     });
  }  
}


public static  class RotasUsuario
{
     public static void rotasUsuario(this WebApplication app)
     {
         app.MapPost("/usuarios", (NovoUsuario novoUsuario) => {
                string conexao = "server=localhost;database=Login;user=root;password=;";  
                using  var conn = new MySqlConnection (conexao);
          
                conn.Open();

                string sql = "INSERT INTO usuario (email, senha) VALUES (@email, @senha)";
                using var cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@email", novoUsuario.email);
                cmd.Parameters.AddWithValue("@senha", novoUsuario.senha); 

                cmd.ExecuteNonQuery();

                return Results.Ok(new { mensagem = "Usuario inserido!", Login = novoUsuario });

         });
     }
}


public static class RotasLogin
{
   public static void LoginRequest(this WebApplication app)
   {
      app.MapPost("/login", (LoginRequest loginRequest) => {
         string conexao = "server=localhost;database=Login;user=root;password=;";
         using var conn = new MySqlConnection(conexao);
         conn.Open();

         string sql = "SELECT * FROM usuario WHERE email = @email AND senha = @senha";
         using var cmd = new MySqlCommand(sql, conn);

         cmd.Parameters.AddWithValue("@email", loginRequest.email);
         cmd.Parameters.AddWithValue("@senha", loginRequest.senha);

         using var reader = cmd.ExecuteReader();

         if (reader.Read())
         {
            return Results.Ok(new { mensagem = "Login bem-sucedido!" });
         }
         else
         {
            return Results.Unauthorized();
         }
      });
   }
}