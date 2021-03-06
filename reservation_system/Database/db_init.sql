DROP TABLE IF EXISTS Providers;
DROP TABLE IF EXISTS Users;
DROP TABLE IF EXISTS Reservations;
DROP TABLE IF EXISTS Tag;

CREATE TABLE Providers(
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    name NVARCHAR(100),
    criteria NVARCHAR(100),
    discription NVARCHAR(2000),
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
    provider_id INTEGER,
    FOREIGN KEY(provider_id) REFERENCES Providers(id)
);

CREATE TABLE Reservations(
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    day NVARCHAR(20),
    from_ INTEGER,
    to_ INTEGER,
    
    provider_id INTEGER,
    user_id INTEGER,
    
    FOREIGN KEY(provider_id) REFERENCES Providers(id),
    FOREIGN KEY(user_id) REFERENCES Users(id)
);

insert into Providers(name,criteria,discription,email,password)
values ('ارائه دهنده ۱', 'این یک کرایتریا است.', 'این یک توضیح در باره ارائه دهنده است.....', 'my@email.com', '123456');

insert into Providers(name,criteria,discription,email,password)
values ('ارائه دهنده ۱', 'این یک کرایتریا است.', 'این یک توضیح در باره ارائه دهنده است.....', 'my@email.com', '123456');

insert into Providers(name,criteria,discription,email,password)
values ('ارائه دهنده ۱', 'این یک کرایتریا است.', 'این یک توضیح در باره ارائه دهنده است.....', 'my@email.com', '123456');

insert into Providers(name,criteria,discription,email,password)
values ('ارائه دهنده ۱', 'این یک کرایتریا است.', 'این یک توضیح در باره ارائه دهنده است.....', 'my@email.com', '123456');

insert into Providers(name,criteria,discription,email,password)
values ('ارائه دهنده ۱', 'این یک کرایتریا است.', 'این یک توضیح در باره ارائه دهنده است.....', 'my@email.com', '123456');

insert into Users(name,email,password)
values ('کاربر ۱', 'my@email.com', '123456');
insert into Users(name,email,password)
values ('کاربر ۲', 'my@email.com', '123456');
insert into Users(name,email,password)
values ('کاربر ۳', 'my@email.com', '123456');
insert into Users(name,email,password)
values ('کاربر ۴', 'my@email.com', '123456');
insert into Users(name,email,password)
values ('کاربر ۵', 'my@email.com', '123456');

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

insert into Reservations(day,from_,to_,provider_id,user_id)
values ("شنبه",11, 12 , 1, 1);
insert into Reservations(day,from_,to_,provider_id,user_id)
values ("شنبه",13, 15 , 1, null);
insert into Reservations(day,from_,to_,provider_id,user_id)
values ("شنبه",15, 17 , 1, null);
insert into Reservations(day,from_,to_,provider_id,user_id)
values ("یکشنبه",10, 12 , 1, 2);
insert into Reservations(day,from_,to_,provider_id,user_id)
values ("یکشنبه",13, 15 , 1, 1);

