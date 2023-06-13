CREATE DATABASE db_citas;
USE db_citas;
CREATE TABLE registros(
	fullname VARCHAR(30) NOT NULL,
    id VARCHAR (15) NOT NULL PRIMARY KEY,
    espe VARCHAR (30) NOT NULL,
    agend DATETIME NOT NULL,
    medico VARCHAR (30) NOT NULL);
    
    SELECT * FROM registros;