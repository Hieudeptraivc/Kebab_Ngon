create database kebabngon
use kebabngon
go
--Tạo bảng Account
create table Account
(
	username varchar(20),
	pass varchar(20)
)
---Thêm dữ liệu bảng Account
Insert into Account	values('ngocdangpro','123456789'),
('hieu','12345')

go
--Tạo Bảng NhanVien
create table NhanVien
(
	MaNV varchar(10) not null,
	TenNV nvarchar(100),
	SDT_NV varchar(10),
	DiachiNV nvarchar(100),
	primary key(MaNV)
)
--Thêm dữ liệu bảng NhanVien
Insert into Nhanvien 
values
('NV0001',N'Trần Ngọc Đăng','0784461117',N'Thừa Thiên Huế'),
('NV0002',N'Nguyễn Văn Hiếu','0784467127',N'Đà Nẵng'),
('NV0003',N'Nguyến Đức Việt Thái','0884461127',N'Quảng Trị'),
('NV0004',N'Văn Phú Đạt','0722461127',N'Quảng Nam'),
('NV0005',N'Nguyễn Văn Phú Khang','0722461127',N'Thừa Thiên Huế')

go
--Tạo hàm tự động tính mã nhân viên mới
create function fADDStaff ()
returns varchar(100)
as 
begin
	declare @result varchar(100),  @tmax varchar(100) ,@tid varchar(12), @rs varchar(100)
	set @tmax=(select max(substring(manv,3,len(manv))) from Nhanvien )
	
	set @tmax=cast(@tmax as int) + 1
	set @result='NV'+REPLICATE('0',4-len(@tmax))+@tmax
	return @result	
end
go

select dbo.fAddStaff()

--Tạo bảng KhachHang
create table KhachHang
(
	MaKH varchar(10) not null,
	TenKH nvarchar(100),
	DiachiKH nvarchar(100),
	primary key(MaKH)
)
select * from KhachHang

--Tạo hàm tự động tính mã khách hàng mới
go
create function fADDCus ()
returns varchar(100)
as 
begin
	declare @result varchar(100),  @tmax varchar(100) ,@tid varchar(12), @rs varchar(100),@tmaxx varchar(20)
	set @tmax=(select max(substring(makh,3,len(makh))) from KhachHang )
	
	set @tmax=cast(@tmax as int) + 1
	set @result='KH'+REPLICATE('0',4-len(@tmax))+@tmax
	return @result	
end
go
select dbo.fAddCus()
--Thêm dữ liệu bảng KhachHang
Insert into KhachHang
values
('KH0001',N'Lê Đức Anh',N'Đà Nẵng'),
('KH0002',N'Trần Thái Linh',N'Đà Nẵng'),
('KH0003',N'Lê Văn Tài',N'Quảng Nam'),
('KH0004',N'Nguyễn Đức Tư',N'Đà Nẵng'),
('KH0005',N'Lê Tuấn Anh',N'Quảng Trị')
go

--Tạo bảng Menu
create table Menu
(
	MaHang varchar(10) not null,
	TenHang varchar(100),
	Dongia int,
	primary key(MaHang)
)
--Thêm dữ liệu bảng Menu
Insert into Menu
values
('MH0001','Banh Mi Chicken',50000),
('MH0002','Banh Mi Beef',60000),
('MH0003','Banh Mi Veggie',40000),
('MH0004','Panini Chicken',50000),
('MH0005','Panini Beef',60000),
('MH0006','Tea',20000),
('MH0007','Kebab plate Chicken',50000),
('MH0008','Kebab plate beef',60000),
('MH0009','French Tacos Chicken',50000),
('MH0010','French Tacos  Beef',60000),
('MH0011','Salads',50000),
('MH0012','Smoothies',40000),
('MH0013','Orange juices',40000),
('MH0014','Watermelon juices',40000)
go
--Tạo hàm tự động tính mã hàng mới
create function fADDProduct ()
returns varchar(100)
as 
begin
	declare @result varchar(100),  @tmax varchar(100) ,@tid varchar(12), @rs varchar(100),@tmaxx varchar(20)
	set @tmax=(select max(substring(MaHang,3,len(MaHang))) from Menu )
	
	set @tmax=cast(@tmax as int) + 1
	set @result='MH'+REPLICATE('0',4-len(@tmax))+@tmax
	return @result	
end
go
select dbo.fAddProduct()

--Tạo Bảng HangDat
Create table HangDat
(
	MaHangDat varchar(10) not null,
	TenHangDat nvarchar(50),
	DiachiNCC nvarchar(100),
	SDT_NCC varchar(100),
	Dongia int,
	primary key(MaHangDat)
)
Insert into HangDat (MaHangDat,TenHangDat,DiachiNCC,SDT_NCC,Dongia)
values
('MHD0001',N'Gà',N'Ngũ Hành Sơn','099379192',300000),
('MHD0002',N'Thịt Bò',N'Ngũ Hành Sơn','099379192',300000),
('MHD0003',N'Rau thơm',N'Ngũ Hành Sơn','099379192',50000),
('MHD0004',N'Cam',N'Ngũ Hành Sơn','099379192',50000),
('MHD0005',N'Dưa hấu',N'Ngũ Hành Sơn','099379192',100000),
('MHD0006',N'Bột déo',N'Ngũ Hành Sơn','099379192',20000),
('MHD0007',N'Trà ô lông',N'Ngũ Hành Sơn','099379192',100000),
('MHD0008',N'Kem Cheese',N'Ngũ Hành Sơn','099379192',300000),
('MHD0009',N'Trà ',N'Ngũ Hành Sơn','099379192',300000),
('MHD0010',N'Cà phê',N'Ngũ Hành Sơn','099379192',330000),
('MHD0011',N'Dứa',N'Ngũ Hành Sơn','099379192',200000),
('MHD0012',N'Xoài',N'Ngũ Hành Sơn','099379192',170000),
('MHD0013',N'Phô mai',N'Ngũ Hành Sơn','099379192',150000),
('MHD0014',N'Rau củ',N'Ngũ Hành Sơn','099379192',100000)

--Tạo hàm tự động tính mã hàng đặt mới
go
create function fADD_HangDat ()
returns varchar(100)
as 
begin
	declare @result varchar(100),  @tmax varchar(100) ,@tid varchar(12), @rs varchar(100),@tmaxx varchar(20)
	set @tmax=(select max(substring(MaHangDat,4,len(MaHangDat))) from HangDat)
	
	set @tmax=cast(@tmax as int) + 1
	set @result='MHD'+REPLICATE('0',4-len(@tmax))+@tmax
	return @result	
end
go
select dbo.fADD_HangDat()
--Tạo bảng Dat
create table Dat
(
	MaDDH varchar(10) not null,
	MaNV varchar(10) not null,
	NgayDat date,
	Chietkhau int, -- tính theo % thanhtien
	TongTienHang int,---=thanhtien-chieukhau
	primary key(MaDDH),
	foreign key(MaNV)  references NhanVien
)
go
--Tạo hàm tự động tính mã đặt hàng mới
create function fADDImport ()
returns varchar(100)
as 
begin
	declare @result varchar(100),  @tmax varchar(100) ,@tid varchar(12), @rs varchar(100),@tmaxx varchar(20)
	set @tmax=(select max(substring(MaDDH,4,len(MaDDH))) from Dat )
	
	set @tmax=cast(@tmax as int) + 1
	set @result='DDH'+REPLICATE('0',4-len(@tmax))+@tmax
	return @result	
end
go
select dbo.fADDImport()
select * from Dat
--Thêm dữ liệu vào bảng Dat
Insert into Dat(maddh,manv,ngaydat)
values
('DDH0001','NV0002','2023/10/12'),
('DDH0002','NV0001','2023/10/13'),
('DDH0003','NV0003','2023/10/14'),
('DDH0004','NV0004','2023/10/15'),
('DDH0005','NV0005','2023/10/16'),
('DDH0006','NV0002','2023/10/17'),
('DDH0007','NV0004','2023/10/18')
go

--Tạo bảng DatChitiet
Create table DatchiTiet
(
	MaDDH varchar(10) not null,
	MaHangDat varchar(10) not null,
	Soluong int,
	ThanhTien int,
	foreign key(MaDDH) references Dat,
	foreign key(MaHangDat) references HangDat
)

select * from DatChiTiet
--Thêm dữ liệu vào bảng DatChitiet
insert into datchitiet(maddh,mahangdat,Soluong)
values('DDH0001','MHD0001',2)
insert into datchitiet(maddh,mahangdat,Soluong)
values('DDH0001','MHD0002',30)
insert into datchitiet(maddh,mahangdat,Soluong)
values('DDH0001','MHD0010',20)
insert into datchitiet(maddh,mahangdat,Soluong)
values('DDH0002','MHD0011',20)
insert into datchitiet(maddh,mahangdat,Soluong)
values('DDH0002','MHD0012',20)
insert into datchitiet(maddh,mahangdat,Soluong)
values('DDH0002','MHD0003',10)
insert into datchitiet(maddh,mahangdat,Soluong)
values('DDH0003','MHD0004',20)
insert into datchitiet(maddh,mahangdat,Soluong)
values('DDH0003','MHD0010',20)
insert into datchitiet(maddh,mahangdat,Soluong)
values('DDH0004','MHD0011',20)
insert into datchitiet(maddh,mahangdat,Soluong)
values('DDH0004','MHD0005',20)
insert into datchitiet(maddh,mahangdat,Soluong)
values('DDH0005','MHD0006',10)
insert into datchitiet(maddh,mahangdat,Soluong)
values('DDH0005','MHD0007',20)
insert into datchitiet(maddh,mahangdat,Soluong)
values('DDH0005','MHD0008',20)
insert into datchitiet(maddh,mahangdat,Soluong)
values('DDH0006','MHD0009',20)
insert into datchitiet(maddh,mahangdat,Soluong)
values('DDH0006','MHD0010',20)
insert into datchitiet(maddh,mahangdat,Soluong)
values('DDH0006','MHD0011',20)
insert into datchitiet(maddh,mahangdat,Soluong)
values('DDH0006','MHD0012',20)
insert into datchitiet(maddh,mahangdat,Soluong)
values('DDH0006','MHD0013',20)
insert into datchitiet(maddh,mahangdat,Soluong)
values('DDH0007','MHD0014',20)
insert into datchitiet(maddh,mahangdat,Soluong)
values('DDH0007','MHD0010',20)
insert into datchitiet(maddh,mahangdat,Soluong)
values('DDH0007','MHD0011',20)
insert into datchitiet(maddh,mahangdat,Soluong)
values('DDH0007','MHD0012',20)
insert into datchitiet(maddh,mahangdat,Soluong)
values('DDH0007','MHD0003',10)
go

----trigger tự động tính tiền thanhtien,chietkhau va TongTienHang :
create trigger tgInsertnUpdate_Dat
on Datchitiet
for insert,update,delete
as 
	declare @dongia int
begin
	set @dongia=(select dongia from HangDat where MaHangDat=(select MaHangDat from inserted))
	update DatChiTiet
	set ThanhTien=@dongia*Soluong
	where MaDDH=(select MaDDH from inserted) and MaHangDat=(select MaHangDat from inserted)

	update dat
	set chietkhau= 0.2*(select sum(thanhtien)
					from datchitiet
					where maddh=(select maddh from inserted))
	where maddh=(select maddh from inserted)
	update dat
	set TongTienHang = (select sum(thanhtien)
					from datchitiet
					where maddh=(select maddh from inserted))-chietkhau
	where maddh=(select maddh from inserted)
	---xoa
	update dat
	set chietkhau= 0.2*(select sum(thanhtien)
					from datchitiet
					where maddh=(select maddh from deleted))
	where maddh=(select maddh from deleted)
	update dat
	set TongTienHang = (select sum(thanhtien)
					from datchitiet
					where maddh=(select maddh from deleted))-chietkhau
	where maddh=(select maddh from deleted)
end
go

--Tạo Bảng Xuat
create table Xuat
(
	MaHDX varchar(10) not null,
	MaKH varchar(10) not null,
	MaNV varchar(10) not null,
	NgayGio datetime,
	Chietkhau int,---=20%thanhtien
	TongTienHang int,
	primary key(MaHDX),
	foreign key(MaKH) references KhachHang,
	foreign key(MaNV) references NhanVien
)
select * from Xuat
--Thêm dữ liệu bảng Xuat
insert into Xuat(mahdx,makh,manv,ngaygio)
values
('HDX0001','KH0001','NV0002','2023/10/11 19:30:00'),
('HDX0002','KH0002','NV0001','2023/10/11 21:30:00'),
('HDX0003','KH0005','NV0003','2023/10/12 19:30:00'),
('HDX0004','KH0004','NV0004','2023/10/13 18:30:00'),
('HDX0005','KH0003','NV0005','2023/10/13 10:30:00'),
('HDX0006','KH0002','NV0002','2023/10/14 11:30:00'),
('HDX0007','KH0001','NV0001','2023/10/14 12:30:00'),
('HDX0008','KH0004','NV0003','2023/10/14 15:30:00'),
('HDX0009','KH0003','NV0002','2023/10/15 19:30:00'),
('HDX0010','KH0002','NV0004','2023/10/15 20:30:00'),
('HDX0011','KH0001','NV0005','2023/10/16 09:30:00')
go
--Tạo hàm tự động tính mã hóa đơn xuất mới
create function fADDExport ()
returns varchar(100)
as 
begin
	declare @result varchar(100),  @tmax varchar(100) ,@tid varchar(12), @rs varchar(100),@tmaxx varchar(20)
	set @tmax=(select max(substring(MaHDX,4,len(MaHDX))) from Xuat)
	
	set @tmax=cast(@tmax as int) + 1
	set @result='HDX'+REPLICATE('0',4-len(@tmax))+@tmax
	return @result	
end
go
select dbo.fADDExport()
------Tao bảng XuatChitiet
create table XuatChiTiet
(
	MaHDX varchar(10) not null,
	MaHang varchar(10) not null,
	Soluong int,
	ThanhTien int, ---=dongia*soluong	
	foreign key(MaHDX) references Xuat,
	foreign key(MaHang) references Menu
)
select * from XuatChiTiet
--Thêm dữ liệu vào bảng XuatChitiet
insert into XuatChiTiet(mahdx,mahang,soluong)
values('HDX0001','MH0014',2)
insert into XuatChiTiet(mahdx,mahang,soluong)
values('HDX0001','MH0005',4)
insert into XuatChiTiet(mahdx,mahang,soluong)
values('HDX0002','MH0013',2)
insert into XuatChiTiet(mahdx,mahang,soluong)
values('HDX0002','MH0007',3)
insert into XuatChiTiet(mahdx,mahang,soluong)
values('HDX0002','MH0004',1)
insert into XuatChiTiet(mahdx,mahang,soluong)
values('HDX0003','MH0009',5)
insert into XuatChiTiet(mahdx,mahang,soluong)
values('HDX0004','MH0014',1)
insert into XuatChiTiet(mahdx,mahang,soluong)
values('HDX0005','MH0011',4)
insert into XuatChiTiet(mahdx,mahang,soluong)
values('HDX0006','MH0012',4)
insert into XuatChiTiet(mahdx,mahang,soluong)
values('HDX0006','MH0014',2)
insert into XuatChiTiet(mahdx,mahang,soluong)
values('HDX0007','MH0001',3)
insert into XuatChiTiet(mahdx,mahang,soluong)
values('HDX0008','MH0001',3)
insert into XuatChiTiet(mahdx,mahang,soluong)
values('HDX0009','MH0001',3)
insert into XuatChiTiet(mahdx,mahang,soluong)
values('HDX0010','MH0003',3)
insert into XuatChiTiet(mahdx,mahang,soluong)
values('HDX0011','MH0004',3)
insert into XuatChiTiet(mahdx,mahang,soluong)
values('HDX0011','MH0005',3)
update xuatchitiet
set soluong=4
where mahdx='HDX11' and mahang='MH04'
delete XuatChiTiet where MaHDX='HDX11' and MaHang='MH04'
select * from xuat
select * from XuatChiTiet
--trigger tự động tính thanhtien và TongTienHang
go
create trigger tgInsertnUpdateXuat
on xuatchitiet
for insert,update,delete
as 
	declare @dongia int
begin
	set @dongia=(select dongia from menu where mahang=(select mahang from inserted))
	update XuatChiTiet
	set ThanhTien=@dongia*Soluong
	where mahdx=(select mahdx from inserted) and mahang=(select mahang from inserted)

	update Xuat
	set chietkhau=0.2*(select sum(thanhtien) 
						from XuatChiTiet
						where mahdx=(select mahdx from inserted))
	where mahdx=(select mahdx from inserted)
	
	update xuat
	set TongTienHang=(select sum(thanhtien) 
						from XuatChiTiet
						where mahdx=(select mahdx from inserted))-chietkhau
	where mahdx=(select mahdx from inserted)
	----xoa
	update Xuat
	set chietkhau=0.2*(select sum(thanhtien)
						from xuatchitiet
						where mahdx=(select mahdx from deleted))
	where mahdx=(select mahdx from deleted)

	update Xuat
	set TongTienHang=(select sum(thanhtien) 
						from XuatChiTiet
						where mahdx=(select mahdx from deleted))-chietkhau
	where mahdx=(select mahdx from deleted)
end
-------
----
--THỰC HIỆN VIỆC MÃ HOÁ CỘT PASS CỦA ACCOUNT
--1. Tạo cột để lưu dữ liệu mã hoá
alter table Account
add [Encrypted Pass] varbinary(Max)
go

--2. Cập nhật dữ liệu đã được mã hoá vào cột vừa tạo
drop table Account
Update Account
set [Encrypted Pass] = ENCRYPTBYPASSPHRASE('Pass', CONVERT(varchar(100),Pass))
go

--3. Xoá bỏ cột chưa được mã hoá
alter table Account drop column Pass

--4. Truy vấn Bảng Account sau khi mã hoá
select * from Account


--Giải mã dữ liệu
select username, CONVERT(char, CONVERT(varchar(100), DECRYPTBYPASSPHRASE('Pass', [Encrypted Pass]))) as Pass from Account 

----------------
go 
-- Tạo index ( nếu muốn) 
create nonclustered index idx_Menu_TenHang
on Menu (TenHang)
go
create nonclustered index idx_Menu_MaHang
on Menu (MaHang)
go
create nonclustered index idx_HangDat_MaHangDat
on HangDat (MaHangDat)
go
create nonclustered index idx_HangDat_TenHangDat
on HangDat (TenHangDat)
go



