create table tfhistory(
Uid int not null primary key identity(1,1) references Registertable(Uid),
Amount nvarchar(50),
Time nvarchar(50),
);

select * from tfhistory
