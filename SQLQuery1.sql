use IIIFOODSYSTEM
go
select student *
from name
go

CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY
)

insert into student values('da','07777','102')

alter table student drop column ps

update student set name='�v�v',phone='0955555',class='105' where stu_id=5

alter table company drop column [ps.]



CREATE TABLE [dbo].[Table]
(
	[company_id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [cname] NVARCHAR(50) NULL, 
    [address] NVARCHAR(MAX) NULL, 
    [phone] INT NULL

	insert into company values('�����~��','�C��G��52��','075586633')


alter table products drop column [ps.]

CREATE TABLE [dbo].[products]
(
	[product_id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [product_name] NVARCHAR(50) NULL, 
    [price] INT NULL, 
    [company_id] INT NULL, 
    [cname] NVARCHAR(50) NULL
)
CREATE TABLE [dbo].[order_detail]
(
	[item_no] INT NOT NULL PRIMARY KEY IDENTITY, 
    [product_id] INT NULL, 
    [company_id] INT NULL, 
    [price] INT NULL, 
    [stu_id] INT NULL
)

insert into order_detail values('product_id','company_id','price','stu_id')

insert into order_detail values
((select product_id from products where product_name=N'�����@���\'),(select distinct company_id from products where cname=N'�����~��'),'500',(select stu_id from student where name=N'����s���U'))


select * from order_detail 


