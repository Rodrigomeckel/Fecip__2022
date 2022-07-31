CREATE TABLE CADASTRO(
nome_completo varchar(70),
dta_nasc char(17),
telefone varchar(11),
cpf nvarchar(17),
senha varchar(50))

DELETE FROM CADASTRO

INSERT INTO CADASTRO(cpf, senha, telefone, dta_nasc) VALUES('123.456.789', '12345','21 97503-3796', '26/03/09')

SELECT * FROM CADASTRO



