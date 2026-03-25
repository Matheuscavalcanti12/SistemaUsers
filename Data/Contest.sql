create database Login;
use Login;

-- Criar tabela usuario
CREATE TABLE usuario (
    id INT AUTO_INCREMENT PRIMARY KEY,
    email VARCHAR(150) NOT NULL ,
    senha VARCHAR(255) NOT NULL,
    role varchar(200) NOT NULL
);

insert into usuario (id, email, senha, role ) values (?,?,?,?);


select*from usuario;