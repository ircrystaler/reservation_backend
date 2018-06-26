DROP TABLE IF EXISTS Providers;
DROP TABLE IF EXISTS Users;
DROP TABLE IF EXISTS Reservations;

CREATE TABLE Providers(
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    name NVARCHAR(100),
    criteria NVARCHAR(100),
    discription NVARCHAR(MAX),
    email VARCHAR(100),
    password VARCHAR(100)
);

CREATE TABLE Users(
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    name NVARCHAR(100),
    email VARCHAR(100),
    password VARCHAR(100)
);

CREATE TABLE Tag(
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    name NVARCHAR(100),
    provider_id INTEGER FOREIGN KEY REFERENCES Providers(id)
);

CREATE TABLE Reservations(
    id INTEGER PRIMARY KEY AUTOINCREMENT
);

insert into Providers(name,criteria,discription,email,password)
values ('provider1', 'This is my criteria', 'this is a discription', 'my@email.com', '123456');

insert into Providers(name,criteria,discription,email,password)
values ('provider2', 'This is my criteria', 'this is a discription', 'my@email.com', '123456');

insert into Providers(name,criteria,discription,email,password)
values ('provider3', 'This is my criteria', 'this is a discription', 'my@email.com', '123456');

insert into Providers(name,criteria,discription,email,password)
values ('provider4', 'This is my criteria', 'this is a discription', 'my@email.com', '123456');

insert into Providers(name,criteria,discription,email,password)
values ('provider5', 'This is my criteria', 'this is a discription', 'my@email.com', '123456');

insert into Users(name,email,password)
values ('user1', 'my@email.com', '123456');
insert into Users(name,email,password)
values ('user2', 'my@email.com', '123456');
insert into Users(name,email,password)
values ('user3', 'my@email.com', '123456');
insert into Users(name,email,password)
values ('user4', 'my@email.com', '123456');
insert into Users(name,email,password)
values ('user5', 'my@email.com', '123456');

insert into Tag(name,provider_id) values('مغر و اعصاب', 1);
insert into Tag(name,provider_id) values('پزشک', 1);
insert into Tag(name,provider_id) values('پزشک', 2);
insert into Tag(name,provider_id) values('پزشک', 3);
insert into Tag(name,provider_id) values('پزشک', 4);
insert into Tag(name,provider_id) values('پزشک', 5);
insert into Tag(name,provider_id) values('با صابقه', 2);
insert into Tag(name,provider_id) values('عمومی', 4);
insert into Tag(name,provider_id) values('ماما', 5);
insert into Tag(name,provider_id) values('فوتبال', 4);
insert into Tag(name,provider_id) values('کودکان', 1);
insert into Tag(name,provider_id) values('جراح', 3);
insert into Tag(name,provider_id) values('دندانپزشک', 1);
insert into Tag(name,provider_id) values('اورولوژیست', 2);
insert into Tag(name,provider_id) values('قلب و عروق', 3);


