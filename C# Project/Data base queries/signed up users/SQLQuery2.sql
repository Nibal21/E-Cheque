Create table Signed_up_users
(
Fname nvarchar(50),
Lname nvarchar(50),
Nidnum nvarchar(50),
Email nvarchar(50),
Accounttyp nvarchar(50),
Selectedbank nvarchar(50),
Accountnum nvarchar(50),
Signatur nvarchar(50),
Username varchar(50) not null,
Pass nvarchar(50),
Primary key(Username),
);

Select * from Signed_up_users