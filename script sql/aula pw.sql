create database dbBancoApp;
use dbBancoApp;
create table usuario(
IdUsu int primary key auto_increment,
nomeUsu varchar(50) not null,
Cargo varchar(50) not null,
DataNasc datetime);
insert into usuario(nomeUsu, Cargo, DataNasc)
                   values ('Nilson', 'Gerente','1928/05/01'),
                          ('Bruno', 'Colaborador', '2000/10/12');
select * from usuario;                                                     