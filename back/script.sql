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
insert into Peca(ID, Nome, Tipo)
value(1, 'Intel Core I5 3200Ghz', 'Processador'),
(2, 'Intel Core I5 7400Ghz', 'Processador'),
(3, 'Intel Core I7 3770Ghz', 'Processador'),
(4, 'Intel Core I7 7700Kk', 'Processador'),
(5, 'Intel Core I9 9900Kk', 'Processador'),
(6, 'Intel Core I9 12900Kk', 'Processador'),
(7, 'Placa Mãe Gigabyte B550M AORUS ELITE', 'Placa Mãe'),
(8, 'Placa Mãe GA-A520M','Placa Mãe'),
(9, 'placa-mãe Asus Prime H410M-E', 'Placa Mãe'),
(10, 'GTX 1060 Ti', 'Placa de Video'),
(11, 'RTX 2060 Ti', 'Placa de Video'),
(12, 'RTX 3080 Ti', 'Placa de Video'),
(13, 'RTX 4090 Ti', 'Placa de Video'),
(14, 'Pente de Ram 4Gb Ddr-4', 'Memória Ram'),
(15, 'Pente de Ram 8Gb Ddr-5', 'Memória Ram'),
(16, 'Pente de Ram 16Gb Ddr-6', 'Memória Ram'),
(17, 'Armazenamento 500 Gb HDD', 'Memória de Armazenamento'),
(18, 'Armazenamento 1 Tb(1000Gb) HDD', 'Memória de Armazenamento'),
(19, 'Armazenamento 250 Gb SSD', 'Memória de Armazenamento'),
(20, 'Monitor Aoc 21.5 Led 75Hz Full HD', 'Monitor'),
(21, 'Monitor Gamer 144Hz 1ms ', 'Monitor'),
(22, 'Monitor Gamer Curvo Samsung Odyssey 49 DQHD 240Hz 1ms', 'Monitor'),
(23, 'Fonte 400w', 'Fonte'),
(24, 'Fonte 600w', 'Fonte'),
(25, 'Fonte 900w', 'Fonte'),
(26, 'Cooler 4 Pas', 'Cooler'),
(27, 'Cooler 5 Pas', 'Cooler'),
(28, 'Cooler 6 pas', 'Cooler');



go

create table Compativel(
	ID int identity primary key,
	Peca1ID int references Peca(ID),
	Peca2ID int references Peca(ID),
);
go