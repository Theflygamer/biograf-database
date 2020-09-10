IF NOT EXISTS(SELECT *
FROM sys.databases
WHERE name = 'Biograf')
BEGIN
    CREATE DATABASE Biograf
END

GO

USE Biograf

GO

IF NOT EXISTS(SELECT *
FROM sysobjects
WHERE name='Kunder')
BEGIN
    CREATE TABLE Kunder
    (
Kundeid int identity (1,1) PRIMARY KEY,
Fnavn varchar (20) not null,
Enavn varchar (25) not  null,
Alder int not null,
Mobilnummer int not null,
Email varchar (30) not null,
    )
END

IF NOT EXISTS(SELECT *
FROM sysobjects
WHERE name='Booking')
BEGIN
    CREATE TABLE Booking
    (
Kundeid int FOREIGN KEY REFERENCES Kunder (Kundeid),
Dag datetime ,
Film varchar (50) not null,
Antalpladser int not null,
Payed bit,
     )
END