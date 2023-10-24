CREATE DATABASE db_petshop;

USE db_petshop;

CREATE TABLE if not exists TB_CLIENTE (
cd_cliente INT NOT NULL primary key auto_increment,
nm_cliente VARCHAR(80) NOT NULL,
cd_cpf CHAR (11) NOT NULL,
cd_telefone CHAR (11) NOT NULL
);
        
CREATE TABLE if not exists TB_PET (
cd_pet INT auto_increment NOT NULL primary key,
cd_cliente INT NOT NULL,
pet_porte VARCHAR(20) NOT NULL,
nm_pet VARCHAR(40) NOT NULL,
constraint fk_cd_cliente FOREIGN KEY (cd_cliente) REFERENCES TB_CLIENTE (cd_cliente)
);
                
CREATE TABLE if not exists TB_SERVICO (
cd_servico INT auto_increment NOT NULL primary key,
tp_servico VARCHAR (40),
dt_servico DATE NOT NULL,
vl_servico DECIMAL (5,2) NOT NULL,
cd_cliente int NOT NULL,
cd_pet int NOT NULL,
constraint fk_id_clienteagend FOREIGN KEY (cd_cliente) REFERENCES TB_CLIENTE (cd_cliente),
    constraint fk_cd_pet FOREIGN KEY (cd_pet) REFERENCES TB_PET (cd_pet)
);