create table Checkbalance
(
Uid int not null primary key identity(1,1) references Registertable(Uid),
Balance nvarchar(100),
Credit nvarchar(50),
);

INSERT INTO Checkbalance VALUES ('100000', '5');
INSERT INTO Checkbalance VALUES ('200000', '10');
INSERT INTO Checkbalance VALUES ('300000', '15');

select * from Checkbalance