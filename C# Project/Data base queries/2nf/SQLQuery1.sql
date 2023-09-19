create table Additionaldata
(
Uid int not null primary key identity(1,1) references Registertable(Uid),
Phonenum nvarchar(50),
Addrss nvarchar (100),
Streetno nvarchar(100),
);