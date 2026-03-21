create database Login;
use Login;

-- Criar tabela usuario
CREATE TABLE usuario (
    id INT AUTO_INCREMENT PRIMARY KEY,
    email VARCHAR(150) NOT NULL ,
    senha VARCHAR(255) NOT NULL
);

insert into usuario (id,email,senha) values (1,'matheus@gmail' , 1234);

select*from usuario;