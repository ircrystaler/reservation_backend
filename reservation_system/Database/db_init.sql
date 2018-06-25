DROP TABLE IF EXISTS Providers;
DROP TABLE IF EXISTS Users;
DROP TABLE IF EXISTS Reservations;

CREATE TABLE Providers(
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    first_name NVARCHAR(50),
    family_name NVARCHAR(50),
    email VARCHAR(100),
    password VARCHAR(100)
);

CREATE TABLE Users(
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    first_name NVARCHAR(50),
    family_name NVARCHAR(50),
    email VARCHAR(100),
    password VARCHAR(100)
);

CREATE TABLE Reservations(
    id INTEGER PRIMARY KEY AUTOINCREMENT
);