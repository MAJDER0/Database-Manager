-- Autor: Tomasz Majder
--Tworzenie bazy danych

DROP DATABASE IF EXISTS ZOO;

IF NOT EXISTS (
        SELECT *
        FROM sys.databases
        WHERE name = 'ZOO'
        )
BEGIN
    CREATE DATABASE [ZOO]
END
GO
--usuwanie tabel o takich samych nazwach

DROP TABLE IF EXISTS ZWIERZETA;
DROP TABLE IF EXISTS SSAKI;
DROP TABLE IF EXISTS RYBY;
DROP TABLE IF EXISTS PTAKI;
DROP TABLE IF EXISTS PLAZY;
DROP TABLE IF EXISTS GADY;

--Przelaczenie na nową baze danych
USE [ZOO]
GO

begin

--Tworzenie tabel

--Wszystkie zwierzeta
CREATE TABLE ZWIERZETA (
  id INT PRIMARY KEY IDENTITY(1,1),
  nazwa VARCHAR(50) NOT NULL,
  typ VARCHAR(50) NOT NULL,
  sposob_odzywiania varchar(50) NOT NULL,
);

--Typy
CREATE TABLE SSAKI (
  zwierze_id INT PRIMARY KEY,
  nazwa VARCHAR(50) NOT NULL,
  FOREIGN KEY (zwierze_id) REFERENCES ZWIERZETA (id) ON DELETE CASCADE,
  sposob_odzywiania varchar(50) NOT NULL
);

CREATE TABLE RYBY (
  zwierze_id INT PRIMARY KEY,
  nazwa VARCHAR(50) NOT NULL,
  FOREIGN KEY (zwierze_id) REFERENCES ZWIERZETA (id) ON DELETE CASCADE,
  sposob_odzywiania varchar(50) NOT NULL
);

CREATE TABLE PTAKI (
  zwierze_id INT PRIMARY KEY,
  nazwa VARCHAR(50) NOT NULL,
  FOREIGN KEY (zwierze_id) REFERENCES ZWIERZETA (id) ON DELETE CASCADE,
  sposob_odzywiania varchar(50) NOT NULL
);

CREATE TABLE PLAZY (
  zwierze_id INT PRIMARY KEY,
  nazwa VARCHAR(50) NOT NULL,
  FOREIGN KEY (zwierze_id) REFERENCES ZWIERZETA (id) ON DELETE CASCADE,
  sposob_odzywiania varchar(50) NOT NULL
);

CREATE TABLE GADY (
  zwierze_id INT PRIMARY KEY,
  nazwa VARCHAR(50) NOT NULL,
  FOREIGN KEY (zwierze_id) REFERENCES ZWIERZETA (id) ON DELETE CASCADE,
  sposob_odzywiania varchar(50) NOT NULL
);

--Wprowadzanie danych. Możemy wprowadzić specyficzne gatunki, jeśli potrzebujemy

-- Dodawanie 15 rekordów dla SSaków
INSERT INTO ZWIERZETA (nazwa, typ, sposob_odzywiania)
VALUES ('Wilk', 'Ssak', 'Miesozerca'),
('Koń', 'Ssak', 'Roslinozerca'),
('Kot', 'Ssak', 'Wszystkozerca'),
('Pies', 'Ssak', 'Miesozerca'),
('Nosorożec', 'Ssak', 'Roslinozerca'),
('Kangur', 'Ssak', 'Roslinozerca'),
('Świnia', 'Ssak', 'Roslinozerca'),
('Żyrafa', 'Ssak', 'Roslinozerca'),
('Słoń morski', 'Ssak', 'Roslinozerca'),
('Koala', 'Ssak', 'Roslinozerca'),
('Lama', 'Ssak', 'Roslinozerca'),
('Opos', 'Ssak', 'Roslinozerca'),
('Puma', 'Ssak', 'Miesozerca'),
('Zebra', 'Ssak', 'Roslinozerca'),
('Lis', 'Ssak', 'Miesozerca');

-- Dodawanie 15 rekordów dla Ryb
INSERT INTO ZWIERZETA (nazwa, typ, sposob_odzywiania)
VALUES ('Karp', 'Ryba', 'Roslinozerca'),
('Sumik szary', 'Ryba', 'Miesozerca'),
('Pstrąg', 'Ryba', 'Miesozerca'),
('Rekin biały', 'Ryba', 'Miesozerca'),
('Dorsz', 'Ryba', 'Miesozerca'),
('Makrela', 'Ryba', 'Miesozerca'),
('Osietra', 'Ryba', 'Miesozerca'),
('Sumik amurski', 'Ryba', 'Miesozerca'),
('Węgorz', 'Ryba', 'Miesozerca'),
('Sardynka', 'Ryba', 'Miesozerca'),
('Tuńczyk', 'Ryba', 'Miesozerca'),
('Świnka morska', 'Ryba', 'Roslinozerca'),
('Łosoś atlantycki', 'Ryba', 'Miesozerca'),
('Haring', 'Ryba', 'Miesozerca'),
('Ryba Księżycowa', 'Ryba', 'Roslinozerca');

-- Dodawanie 15 rekordów dla Ptaków
INSERT INTO ZWIERZETA (nazwa, typ, sposob_odzywiania)
VALUES ('Kruk', 'Ptak', 'Wszystkozerca'),
('Sowa', 'Ptak', 'Mięsożerna'),
('Dzięcioł', 'Ptak', 'Wszystkozerca'),
('Papuga', 'Ptak', 'Roslinożerca'),
('Kolibri', 'Ptak', 'Nektarożerna'),
('Gołąb', 'Ptak', 'Roslinożerca'),
('Jastrząb', 'Ptak', 'Mięsożerna'),
('Wróbel domowy', 'Ptak', 'Roslinożerca'),
('Pingwin cesarski', 'Ptak', 'Mięsożerna'),
('Sikorka', 'Ptak', 'Wszystkozerca'),
('Kaczka', 'Ptak', 'Wszystkozerca'),
('Orzeł bielik', 'Ptak', 'Mięsożerna'),
('Pliszka siwa', 'Ptak', 'Wszystkozerca'),
('Głuszec', 'Ptak', 'Roslinożerca'),
('Czapla biała', 'Ptak', 'Mięsożerna');

-- Dodawanie 15 rekordów dla Plaz
INSERT INTO ZWIERZETA (nazwa, typ, sposob_odzywiania)
VALUES ('Żółw czerwonolicy', 'Plaz', 'Roslinożerca'),
('Trachemys skryty', 'Plaz', 'Roslinożerca'),
('Żaba śmieszka', 'Plaz', 'Wszystkożerca'),
('Jaszczurka zwinka', 'Plaz', 'Wszystkożerca'),
('Żaba moczarowa', 'Plaz', 'Wszystkożerca'),
('Żółw twardoskóry', 'Plaz', 'Wszystkożerca'),
('Zaskroniec', 'Plaz', 'Wszystkożerca'),
('Trachemys scripta elegans', 'Plaz', 'Roslinożerca'),
('Żaba wodna', 'Plaz', 'Wszystkożerca'),
('Żółw żółtodzioby', 'Plaz', 'Wszystkożerca'),
('Żaba ropucha', 'Plaz', 'Wszystkożerca'),
('Jaszczurka żyworodna', 'Plaz', 'Wszystkożerca'),
('Zaskroniec zwyczajny', 'Plaz', 'Wszystkożerca'),
('Żółw błotny', 'Plaz', 'Wszystkożerca'),
('Trachemys', 'Plaz', 'Roslinożerca');

-- Dodawanie 15 rekordów dla Gadów
INSERT INTO ZWIERZETA (nazwa, typ, sposob_odzywiania)
VALUES ('Kameleon', 'Gad', 'Wszystkożerca'),
('Wąż wodny', 'Gad', 'Mięsożerca'),
('Jaszczurka zielona', 'Gad', 'Wszystkożerca'),
('Wąż zbożowy', 'Gad', 'Mięsożerca'),
('Legwan', 'Gad', 'Wszystkożerca'),
('Wąż korniki', 'Gad', 'Mięsożerca'),
('Zmija zygzakowata', 'Gad', 'Mięsożerca'),
('Jaszczurka żółwia', 'Gad', 'Wszystkożerca'),
('Wąż żmija', 'Gad', 'Mięsożerca'),
('Wąż królewski', 'Gad', 'Mięsożerca'),
('Jaszczurka zielonkawa', 'Gad', 'Wszystkożerca'),
('Wąż wężojad', 'Gad', 'Mięsożerca'),
('Agama skalna', 'Gad', 'Wszystkożerca'),
('Wąż szlamnik', 'Gad', 'Mięsożerca'),
('Kameleon wątpliwy', 'Gad', 'Wszystkożerca');

INSERT INTO SSAKI(zwierze_id, nazwa,sposob_odzywiania) SELECT id, nazwa,sposob_odzywiania FROM ZWIERZETA WHERE typ = 'Ssak';

INSERT INTO RYBY (zwierze_id, nazwa,sposob_odzywiania) SELECT id, nazwa,sposob_odzywiania FROM ZWIERZETA WHERE typ = 'Ryba';

INSERT INTO PTAKI (zwierze_id, nazwa,sposob_odzywiania) SELECT id, nazwa,sposob_odzywiania FROM ZWIERZETA WHERE typ = 'Ptak';

INSERT INTO PLAZY (zwierze_id, nazwa,sposob_odzywiania) SELECT id, nazwa,sposob_odzywiania FROM ZWIERZETA WHERE typ = 'Plaz';

INSERT INTO GADY (zwierze_id, nazwa,sposob_odzywiania) SELECT id, nazwa,sposob_odzywiania FROM ZWIERZETA WHERE typ = 'Gad';

END