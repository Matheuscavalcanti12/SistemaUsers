
namespace JWT;

using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
public class TokenService
{
    public string GerarToken(string email, string role)
    {
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("minha_chave_super_secreta_3112"));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
      /*conjunto de informações que vai pro token,
      como meus campos de email e role que vao ser validados,
      são eles que vao no claims
      */
        var claims = new[]
        {
        new Claim(ClaimTypes.Name, email),
        //criando o role(papel)
        new Claim(ClaimTypes.Role, role)
    };

        var token = new JwtSecurityToken(
            // issuer: "meuSistema",
            //audience: "meuSistema",
            //adaptaveis e tem que bater com a autenticação do jwt no program.
            issuer: "meuSistema",
            audience: "meuSistema",
            claims: claims,
            expires: DateTime.Now.AddHours(1),
            signingCredentials: creds
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}