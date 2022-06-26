CREATE DATABASE MemberManagement
USE MemberManagement_1
GO

CREATE TABLE tblMember(
	MemberId int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Password nvarchar(30) NOT NULL,
	Email nvarchar(100) NOT NULL,
	CompanyName nvarchar(40) NOT NULL,
	City nvarchar(15) NOT NULL,
	Country nvarchar(15) NOT NULL
)

CREATE TABLE tblOrder(
	OrderId int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	MemberId int NOT NULL,
	OrderDate datetime NOT NULL,
	RequiredDate datetime NULL,
	ShippedDate datetime NULL,
	Freight money NULL,
	FOREIGN KEY (MemberId) REFERENCES tblMember(MemberId)
)

CREATE TABLE tblProduct(
	ProductId int NOT NULL,
	CategoryId int NOT NULL,
	ProductName nvarchar(40) NOT NULL,
	Weight nvarchar(20) NOT NULL,
	UnitPrice money NOT NULL,
	UnitslnStock int NOT NULL
)


CREATE TABLE tblOrderDetail(
	OrderId int PRIMARY KEY NOT NULL,
	ProductId int NOT NULL,
	UnitPrice money NOT NULL,
	Quantity int NOT NULL,
	Discount float NOT NULL,
	FOREIGN KEY (OrderId) REFERENCES tblOrder(OrderId),
	FOREIGN KEY (ProductId) REFERENCES tblProduct(ProductId)
)




INSERT INTO tblMember(Password,Email,CompanyName,City,Country) VALUES (N'trung1801','nguyentantrung9179@gmail.com',N'Trung Thành Đoàn','HCM',N'Việt Nam')
INSERT INTO tblMember(Password,Email,CompanyName,City,Country) VALUES (N'trungse151131','trungse151131@gmail.com',N'Trung Trương','HCM',N'Việt Nam')
INSERT INTO tblMember(Password,Email,CompanyName,City,Country) VALUES (N'nam2706','nam2706@gmail.com',N'Thanh Nam','BD',N'Việt Nam')



INSERT INTO tblOrder(MemberId,OrderDate,RequiredDate,ShippedDate,Freight) VALUES(1,'2022/05/25','2022/05/30','2022/05/29',30.000)
INSERT INTO tblOrder(MemberId,OrderDate,RequiredDate,ShippedDate,Freight) VALUES(3,'2022/04/20','2022/05/05','2022/04/27',35.000)
INSERT INTO tblOrder(MemberId,OrderDate,RequiredDate,ShippedDate,Freight) VALUES(2,'2022/03/05','2022/03/25','2022/03/20',45.000)


INSERT INTO tblProduct(CategoryId,ProductName,Weight,UnitPrice,UnitslnStock) VALUES(1,N'Áo adidas','0.2',1000000, 20)
INSERT INTO tblProduct(CategoryId,ProductName,Weight,UnitPrice,UnitslnStock) VALUES(2,N'Áo khoác','0.5',5000000, 30)
INSERT INTO tblProduct(CategoryId,ProductName,Weight,UnitPrice,UnitslnStock) VALUES(3,N'Quần jean','0.5',10000000, 50)
INSERT INTO tblProduct(CategoryId,ProductName,Weight,UnitPrice,UnitslnStock) VALUES(4,N'Quần jogger','0.4',900000, 55)


INSERT INTO tblOrderDetail(OrderId,ProductId,UnitPrice,Quantity,Discount) VALUES(1,2,50000,5,5000)
INSERT INTO tblOrderDetail(OrderId,ProductId,UnitPrice,Quantity,Discount) VALUES(2,1,25000,2,5000)
INSERT INTO tblOrderDetail(OrderId,ProductId,UnitPrice,Quantity,Discount) VALUES(4,3,60000,10,10000)
