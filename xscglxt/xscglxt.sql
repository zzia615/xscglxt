create database xscglxt
go

use xscglxt
go
--用户信息表
create table yhxx
(
yhzh nvarchar(20) not null primary key, --用户账号
yhxm nvarchar(20) not null,--用户姓名
yhmm nvarchar(50) not null --用户密码
)
go

insert into yhxx(yhzh,yhxm,yhmm) values('admin','admin','admin')
go

--新生信息表
create table xsxx
(
xsbm nvarchar(20) not null primary key, --学号
xsxm nvarchar(20) not null, --姓名
xsxb nvarchar(5) not null, --性别
xszy nvarchar(50) not null,--专业
xsbj nvarchar(50) not null, --班级
rxrq date not null --入学日期
)
go
--毕业生信息表
create table bysxx
(
xsbm nvarchar(20) not null primary key, --学号
xsxm nvarchar(20) not null, --姓名
xsxb nvarchar(5) not null, --性别
xszy nvarchar(50) not null,--专业
xsbj nvarchar(50) not null, --班级
byrq date not null --毕业日期
)
go
--违纪信息表
create table wjsxx
(
id int identity(1,1) not null primary key, --主键
xsbm nvarchar(20) not null, --学号
xsxm nvarchar(20) not null, --姓名
xsxb nvarchar(5) not null, --性别
xszy nvarchar(50) not null,--专业
xsbj nvarchar(50) not null, --班级
wjnr nvarchar(500) not null, --违纪内容
wjcf nvarchar(500) not null --违纪惩罚

)
go
--困难生信息表
create table knsxx
(
xsbm nvarchar(20) not null primary key, --学号
xsxm nvarchar(20) not null, --姓名
xsxb nvarchar(5) not null, --性别
xszy nvarchar(50) not null,--专业
xsbj nvarchar(50) not null, --班级
beizhu nvarchar(500) null --备注
)
go
--优秀学生信息表
create table yxsxx
(
xsbm nvarchar(20) not null primary key, --学号
xsxm nvarchar(20) not null, --姓名
xsxb nvarchar(5) not null, --性别
xszy nvarchar(50) not null,--专业
xsbj nvarchar(50) not null, --班级
beizhu nvarchar(500) null --备注
)
go

