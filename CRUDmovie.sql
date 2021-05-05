use  pubs;
create table tblMovie(id int,name varchar(20),duration float)
alter table tblMovie
add  id int identity(1,1);
select * from tblMovie;


create table tblMovies(id int identity(1,1),name varchar(20),duration float);
insert into tblMovies(name,duration) values('Titanic',113)
insert into tblMovies(name,duration) values('Twilight',115),('Vampire Diaries',118)
insert into tblMovies(name,duration) values('Avatar',120),('Narnia',125)
select * from tblMovies;