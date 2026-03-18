🚀 API de Cadastro de Usuários

Projeto simples de API REST desenvolvido com ASP.NET Core + MySQL, permitindo cadastro e listagem de usuários.

📌 Funcionalidades

✔️ Cadastro de usuários
✔️ Listagem de usuários
✔️ Integração com banco de dados MySQL
✔️ Testes via Postman ou Front-end HTML
--

🛠️ Tecnologias utilizadas

C#

ASP.NET Core (Minimal API)

MySQL

MySql.Data

HTML, CSS e JavaScript (para testes)
--
📂 Estrutura do Projeto

RotasUsuario → Cadastro de usuários (POST)

RotasContest → Listagem de usuários (GET)

Models → Classes de dados (Usuario, NovoUsuario)
--
🔗 Rotas da API
📥 Criar usuário
POST /usuarios
Body (JSON):
{
  "email": "teste@email.com",
  "senha": "123"
}
📤 Listar usuários
GET /usuarios
🗄️ Banco de Dados
Script SQL:
CREATE DATABASE IF NOT EXISTS Login;

USE Login;

CREATE TABLE usuario (
    id INT AUTO_INCREMENT PRIMARY KEY,
    email VARCHAR(150) NOT NULL UNIQUE,
    senha VARCHAR(255) NOT NULL
);
--
▶️ Como executar o projeto

Clone o repositório:

git clone https://github.com/seu-usuario/seu-repo.git

Acesse a pasta:

cd seu-repo

Execute o projeto:

dotnet run

A API estará disponível em:

http://localhost:PORTA
🧪 Testando a API
--
Você pode testar usando:

Postman

Insomnia

Ou o arquivo HTML de cadastro
--
⚠️ Observações

Este projeto é educacional

Senhas ainda estão sendo salvas sem criptografia (melhoria futura)

CORS pode precisar ser habilitado para integração com front-end
--

🚀 Próximos passos

🔐 Implementar login

🔑 Autenticação com JWT

🔒 Criptografia de senha

🎨 Melhorar interface do usuário
--
👨‍💻 Autor

Desenvolvido por [Matheus Cavalcanti]

🔥 Projeto em evolução — acompanhando meu aprendizado em APIs e desenvolvimento backend.
