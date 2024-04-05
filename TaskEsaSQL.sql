CREATE TABLE Oggetto_Celeste(
	
	oggettoCelesteId INT PRIMARY KEY IDENTITY (1,1),
	nome VARCHAR (250) NOT NULL,
	codice VARCHAR(250) DEFAULT NEWID(),
	dataScoperta DATE NOT NULL,
	scopritore VARCHAR(250) NOT NULL,
	tipologia VARCHAR(250) NOT NULL,
	distanzaTerra DECIMAL(18,6)NOT NULL,
	angoloPolare DECIMAL(10, 8) NOT NULL,
    distanzaRadiale DECIMAL(18, 6) NOT NULL,

);
CREATE TABLE Sistema(
	
	sistemaId INT  PRIMARY KEY IDENTITY (1,1),
	nome VARCHAR(250) NOT NULL,
	codice VARCHAR(250) DEFAULT NEWID(),
	tipo VARCHAR(250) NOT NULL
);

CREATE TABLE Oggetto_Sistema(
	oggettoCelesteRIF INT NOT NULL,
	sistemaRIF INT NOT NULL
	FOREIGN KEY (sistemaRIF) REFERENCES Sistema (sistemaId),
	FOREIGN KEY (oggettoCelesteRIF) REFERENCES Oggetto_Celeste (oggettoCelesteId),
	PRIMARY KEY (sistemaRIF,oggettoCelesteRIF)
);

INSERT INTO Oggetto_Celeste(nome,
	dataScoperta,
	scopritore,
	tipologia,
	distanzaTerra,
	angoloPolare,
    distanzaRadiale) VALUES ('Stella Proxima Centauri', '2023-08-15', 'AstronomoX', 'Stella', 4.24, 45, 0.3)

	INSERT INTO Sistema(nome, tipo) 
VALUES ('Sistema Solare', 'Stellare');


INSERT INTO Oggetto_Sistema(
	oggettoCelesteRIF,sistemaRIF) VALUES (1,1);

SELECT * FROM Oggetto_Celeste 
	JOIN  Oggetto_Sistema ON Oggetto_Celeste.oggettoCelesteId = Oggetto_Sistema.oggettoCelesteRIF
	JOIN Sistema ON Oggetto_Sistema.sistemaRIF= Sistema.sistemaId
