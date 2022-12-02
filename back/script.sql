use master
go

if exists(select * from sys.databases where name = 'TCCSenai')
	drop database TCCSenai
go

create database TCCSenai
go

use TCCSenai
go

create table Usuario(
	ID int identity primary key,
	Nome varchar(100) not null,
	Sobrenome varchar(100) not null,
	Email varchar(150) not null,
	Userpass varchar(150) not null
);
go

create table Peca(
	ID int identity primary key,
	Nome varchar(300) not null,
	Tipo int not null
);
go

create table Compativel(
	ID int identity primary key,
	Peca1ID int references Peca(ID),
	Peca2ID int references Peca(ID),
);
go