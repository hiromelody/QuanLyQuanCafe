-- Tạo database mới (để SQL chọn đường dẫn mặc định --> C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA)
USE [master]
CREATE DATABASE QuanLyQuanCafe;
GO

ALTER DATABASE QuanLyQuanCafe SET COMPATIBILITY_LEVEL = 160;
GO

USE QuanLyQuanCafe;
GO

-- ======================================================
-- Tạo bảng (không tạo FK trước) -- thứ tự: bảng cha trước
-- ======================================================

CREATE TABLE dbo.Ban (
    MaBan varchar(10) NOT NULL PRIMARY KEY,
    SucChua int NOT NULL CONSTRAINT CK_Ban_SucChua CHECK (SucChua > 0),
    TrangThai int NOT NULL
);
GO

CREATE TABLE dbo.KhachHang (
    MaKH varchar(10) NOT NULL PRIMARY KEY,
    TenKH nvarchar(100) NOT NULL,
    SDT varchar(15) NULL,
    DiaChi nvarchar(200) NULL,
    CONSTRAINT UQ_KhachHang_SDT UNIQUE (SDT),
    CONSTRAINT CK_KhachHang_SDT CHECK (SDT IS NULL OR (LEN(SDT) = 10 AND SDT NOT LIKE '%[^0-9]%'))
);
GO

CREATE TABLE dbo.NhanVien (
    MaNV varchar(10) NOT NULL PRIMARY KEY,
    TenNV nvarchar(100) NOT NULL,
    MatKhau varchar(200) NOT NULL,   -- để dự phòng hash sau này
    SDT varchar(15) NULL,
    DiaChi nvarchar(200) NULL,
    CONSTRAINT UQ_NhanVien_SDT UNIQUE (SDT),
    CONSTRAINT CK_NhanVien_SDT CHECK (SDT IS NULL OR (LEN(SDT) = 10 AND SDT NOT LIKE '%[^0-9]%'))
);
GO

CREATE TABLE dbo.LoaiDoUong (
    MaLoai varchar(10) NOT NULL PRIMARY KEY,
    TenLoai nvarchar(100) NOT NULL
);
GO
CREATE TABLE dbo.DoUong (
    MaDU varchar(10) NOT NULL PRIMARY KEY,
    TenDU nvarchar(100) NOT NULL,
    MaLoai varchar(10) NOT NULL,
    DonGia decimal(18,2) NOT NULL CONSTRAINT CK_DoUong_DonGia CHECK (DonGia >= 0),
    HinhAnh nvarchar(max) NULL
);
GO

CREATE TABLE dbo.HoaDon (
    MaHD int identity(1,1) NOT NULL PRIMARY KEY,
    NgayLap datetime NOT NULL DEFAULT GETDATE(),
    MaNV varchar(10) NULL,
    MaKH varchar(10) NULL,
    MaBan varchar(10) NULL,
    TongTien decimal(18,2) NOT NULL DEFAULT 0,
    TrangThai int NOT NULL
);
GO

CREATE TABLE dbo.ChiTietHoaDon (
    MaHD int  NOT NULL,
    MaDU varchar(10) NOT NULL,
    SoLuong int NOT NULL CONSTRAINT CK_CTHD_SoLuong CHECK (SoLuong > 0),
    DonGia decimal(18,2) NOT NULL,
    ThanhTien AS (SoLuong * DonGia) PERSISTED,
    CONSTRAINT PK_CTHD PRIMARY KEY (MaHD, MaDU)
);
GO

-- ======================================================
-- Chèn dữ liệu (theo thứ tự: cha -> con)
-- ======================================================

INSERT INTO dbo.Ban (MaBan, SucChua, TrangThai) VALUES
('B01', 2, 0),
('B02', 2, 0),
('B03', 4, 0),
('B04', 4, 0),
('B05', 6, 0),
('B06', 6, 0),
('B07', 4, 0),
('B08', 4, 0),
('B09', 3, 0),
('B10', 3, 0);
GO

INSERT INTO dbo.KhachHang (MaKH, TenKH, SDT, DiaChi) VALUES
('KH01', N'Nguyễn Văn A', '0900000001', N'Quận 1'),
('KH02', N'Trần Thị B', '0900000002', N'Quận 2'),
('KH03', N'Lê Văn C', '0900000003', N'Quận 3');
GO

INSERT INTO dbo.NhanVien (MaNV, TenNV, MatKhau, SDT, DiaChi) VALUES
('NV01', N'Lê Quý Đôn', '123456', '0988888888', N'Ký túc xá Cao Thắng'),
('NV02', N'Nguyễn Trãi', '123456', '0977777777', N'Quận 1'),
('NV03', N'Trần Hưng Đạo', '123456', '0966666666', N'Quận 3');
GO

INSERT INTO dbo.LoaiDoUong (MaLoai, TenLoai) VALUES
('L01', N'Cà phê'),
('L02', N'Trà sữa'),
('L03', N'Nước ép'),
('L04', N'Sinh tố'),
('L05', N'Đá xay');
GO

INSERT INTO dbo.DoUong (MaDU, TenDU, MaLoai, DonGia, HinhAnh) VALUES
('DU01', N'Cà phê đen', 'L01', 20000, N'cfden.jpg'),
('DU02', N'Cà phê sữa', 'L01', 25000, N'cfsua.jpg'),
('DU03', N'Bạc xỉu',  'L01', 30000, N'bacxiu.jpg'),
('DU04', N'Trà sữa truyền thống', 'L02', 35000, N'tstt.jpg'),
('DU05', N'Trà sữa matcha', 'L02', 38000, N'tsmatcha.jpg'),
('DU06', N'Nước ép cam', 'L03',40000, N'cam.jpg'),
('DU07', N'Nước ép dưa hấu', 'L03',38000, N'duahau.jpg'),
('DU08', N'Sinh tố bơ', 'L04',45000, N'stb.jpg'),
('DU09', N'Sinh tố dâu', 'L04',45000, N'std.jpg'),
('DU10', N'Oreo đá xay', 'L05',50000, N'oreo.jpg'),
('DU11', N'Chocolate đá xay', 'L05',52000, N'choco.jpg');
GO

--Chèn HoaDon
INSERT INTO dbo.HoaDon (NgayLap, MaNV, MaKH, MaBan, TrangThai) VALUES
(GETDATE(), 'NV01', 'KH01', 'B01', 0),
(GETDATE(), 'NV01', 'KH02', 'B02', 0),
(GETDATE(), 'NV02', 'KH03', 'B03', 0),
(GETDATE(), 'NV01', 'KH01', 'B04', 0),
(GETDATE(), 'NV03', 'KH02', 'B05', 0),
(GETDATE(), 'NV02', 'KH03', 'B06', 0);
GO

-- Chèn Chi Tiết
INSERT INTO dbo.ChiTietHoaDon (MaHD, MaDU, SoLuong, DonGia) VALUES
('HD01','DU01',2,25000),
('HD01','DU04',1,35000),

('HD02','DU02',1,25000),
('HD02','DU06',2,40000),

('HD03','DU03',3,30000),

('HD04','DU05',1,38000),

('HD05','DU08',2,45000),
('HD05','DU10',1,50000),

('HD06','DU01',1,25000),
('HD06','DU11',1,52000);
GO

-- ======================================================
-- Thêm FK sau khi dữ liệu cha đã có (an toàn)
-- ======================================================
ALTER TABLE dbo.DoUong
    ADD CONSTRAINT FK_DoUong_Loai FOREIGN KEY (MaLoai) REFERENCES dbo.LoaiDoUong(MaLoai);
GO

ALTER TABLE dbo.HoaDon
    ADD CONSTRAINT FK_HD_Ban FOREIGN KEY (MaBan) REFERENCES dbo.Ban(MaBan);
GO

ALTER TABLE dbo.HoaDon
    ADD CONSTRAINT FK_HD_KH FOREIGN KEY (MaKH) REFERENCES dbo.KhachHang(MaKH);
GO

ALTER TABLE dbo.HoaDon
    ADD CONSTRAINT FK_HD_NV FOREIGN KEY (MaNV) REFERENCES dbo.NhanVien(MaNV);
GO

ALTER TABLE dbo.ChiTietHoaDon
    ADD CONSTRAINT FK_CTHD_DU FOREIGN KEY (MaDU) REFERENCES dbo.DoUong(MaDU);
GO

ALTER TABLE dbo.ChiTietHoaDon
    ADD CONSTRAINT FK_CTHD_HD FOREIGN KEY (MaHD) REFERENCES dbo.HoaDon(MaHD);
GO

-- Kiểm tra nhanh:
--SELECT COUNT(*) AS BanCount FROM dbo.Ban;
--SELECT COUNT(*) AS DoUongCount FROM dbo.DoUong;
--SELECT COUNT(*) AS HoaDonCount FROM dbo.HoaDon;
--SELECT COUNT(*) AS CTHDCount FROM dbo.ChiTietHoaDon;
--GO