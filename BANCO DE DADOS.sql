--CRIA��O BANCO DE DADOS DA APLICA��O

--APAGA TABELAS E BANCO SE EXISTIREM

DROP TABLE IF EXISTS INSS
DROP TABLE IF EXISTS SALARIOS
DROP DATABASE IF EXISTS BANCO5

--CRIA BANCO E DA USE NELE
CREATE DATABASE BANCO5
USE BANCO5

--CRIA TABELA SALARIOS
CREATE TABLE SALARIOS (
	ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	NOME VARCHAR(80) NOT NULL,
	SALARIO_BRUTO MONEY NOT NULL,
	DESCONTO_OUTROS MONEY NOT NULL,
	QTD_DEPENDENTES INT,
	INSS MONEY NOT NULL,
	ANO_INSS INT NOT NULL,
	IRRF MONEY,
	SALARIO_LIQUIDO MONEY NOT NULL)

--CRIA TABELA INSS
CREATE TABLE INSS (
	ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	ID_FAIXA INT NOT NULL,
	DE DECIMAL(10,2) NOT NULL,
	ATE DECIMAL(10,2) NOT NULL,
	ALIQUOTA DECIMAL(10,2) NOT NULL,
	PORC_A_DEDUZIR DECIMAL(10,2) NOT NULL,
	ANO INT NOT NULL)

--INSERE DADOS INSS 2023
INSERT INTO INSS 
	(ID_FAIXA, DE, ATE, ALIQUOTA, PORC_A_DEDUZIR, ANO)
VALUES
	(1, 0.01, 1100, 0.075, 0, 2023),
	(2, 1100.01, 2203.48, 0.09, 16.5, 2023),
	(3, 2203.49, 3305.22, 0.12, 82.604, 2023),
	(4, 3305.23, 6433.57, 0.14, 148.708, 2023)

SELECT 'BANCO CRIADO'