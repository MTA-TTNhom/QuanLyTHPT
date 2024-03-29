USE [QLHocSinhTHPT]
GO
/****** Object:  Table [dbo].[DANTOC]    Script Date: 9/13/2019 3:47:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DANTOC](
	[MaDanToc] [varchar](6) NOT NULL,
	[TenDanToc] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDanToc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GIAOVIEN]    Script Date: 9/13/2019 3:47:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GIAOVIEN](
	[MaGiaoVien] [varchar](6) NOT NULL,
	[TenGiaoVien] [nvarchar](30) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[DienThoai] [varchar](15) NOT NULL,
	[MaMonHoc] [varchar](6) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaGiaoVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HOCSINH]    Script Date: 9/13/2019 3:47:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HOCSINH](
	[MaHocSinh] [varchar](6) NOT NULL,
	[HoTen] [nvarchar](30) NOT NULL,
	[GioiTinh] [bit] NULL,
	[NgaySinh] [datetime] NULL,
	[NoiSinh] [nvarchar](50) NOT NULL,
	[MaDanToc] [varchar](6) NOT NULL,
	[MaTonGiao] [varchar](6) NOT NULL,
	[HoTenCha] [nvarchar](30) NOT NULL,
	[MaNNghiepCha] [varchar](6) NOT NULL,
	[HoTenMe] [nvarchar](30) NOT NULL,
	[MaNNghiepMe] [varchar](6) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHocSinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHOILOP]    Script Date: 9/13/2019 3:47:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHOILOP](
	[MaKhoiLop] [varchar](6) NOT NULL,
	[TenKhoiLop] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhoiLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOAINGUOIDUNG]    Script Date: 9/13/2019 3:47:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOAINGUOIDUNG](
	[MaLoai] [varchar](6) NOT NULL,
	[TenLoaiND] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOP]    Script Date: 9/13/2019 3:47:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOP](
	[MaLop] [varchar](10) NOT NULL,
	[TenLop] [nvarchar](30) NOT NULL,
	[MaKhoiLop] [varchar](6) NOT NULL,
	[MaNamHoc] [varchar](6) NOT NULL,
	[SiSo] [int] NOT NULL,
	[MaGiaoVien] [varchar](6) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MONHOC]    Script Date: 9/13/2019 3:47:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MONHOC](
	[MaMonHoc] [varchar](6) NOT NULL,
	[TenMonHoc] [nvarchar](30) NOT NULL,
	[SoTiet] [int] NOT NULL,
	[HeSo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMonHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NAMHOC]    Script Date: 9/13/2019 3:47:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NAMHOC](
	[MaNamHoc] [varchar](6) NOT NULL,
	[TenNamHoc] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNamHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NGHENGHIEP]    Script Date: 9/13/2019 3:47:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NGHENGHIEP](
	[MaNghe] [varchar](6) NOT NULL,
	[TenNghe] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNghe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NGUOIDUNG]    Script Date: 9/13/2019 3:47:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NGUOIDUNG](
	[MaND] [varchar](6) NOT NULL,
	[MaLoai] [varchar](6) NOT NULL,
	[TenND] [nvarchar](30) NOT NULL,
	[TenDNhap] [varchar](30) NOT NULL,
	[MatKhau] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHANCONG]    Script Date: 9/13/2019 3:47:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHANCONG](
	[STT] [int] IDENTITY(1,1) NOT NULL,
	[MaNamHoc] [varchar](6) NOT NULL,
	[MaLop] [varchar](10) NOT NULL,
	[MaMonHoc] [varchar](6) NOT NULL,
	[MaGiaoVien] [varchar](6) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[STT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[QUYDINH]    Script Date: 9/13/2019 3:47:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUYDINH](
	[TuoiCanDuoi] [int] NOT NULL,
	[TuoiCanTren] [int] NOT NULL,
	[SiSoCanDuoi] [int] NOT NULL,
	[SiSoCanTren] [int] NOT NULL,
	[ThangDiem] [int] NOT NULL,
	[TenTruong] [nvarchar](100) NULL,
	[DiaChiTruong] [nvarchar](100) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TONGIAO]    Script Date: 9/13/2019 3:47:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TONGIAO](
	[MaTonGiao] [varchar](6) NOT NULL,
	[TenTonGiao] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTonGiao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[DANTOC] ([MaDanToc], [TenDanToc]) VALUES (N'DT0001', N'Kinh')
INSERT [dbo].[DANTOC] ([MaDanToc], [TenDanToc]) VALUES (N'DT0002', N'Tay')
INSERT [dbo].[DANTOC] ([MaDanToc], [TenDanToc]) VALUES (N'DT0003', N'Nung')
INSERT [dbo].[DANTOC] ([MaDanToc], [TenDanToc]) VALUES (N'DT0004', N'Mong')
INSERT [dbo].[GIAOVIEN] ([MaGiaoVien], [TenGiaoVien], [DiaChi], [DienThoai], [MaMonHoc]) VALUES (N'GV0001', N'Nguyen Hoang Tung', N'100 Tran Hung Dao, Long Xuyen', N'0975058876', N'MH0001')
INSERT [dbo].[GIAOVIEN] ([MaGiaoVien], [TenGiaoVien], [DiaChi], [DienThoai], [MaMonHoc]) VALUES (N'GV0002', N'Phan Hong Nhung', N'Lac Quoi - Tri Ton', N'0976630315', N'MH0002')
INSERT [dbo].[GIAOVIEN] ([MaGiaoVien], [TenGiaoVien], [DiaChi], [DienThoai], [MaMonHoc]) VALUES (N'GV0003', N'Huynh Thanh Truc', N'10C Nguyen Trung Truc, Chau Doc', N'0699015456', N'MH0003')
INSERT [dbo].[GIAOVIEN] ([MaGiaoVien], [TenGiaoVien], [DiaChi], [DienThoai], [MaMonHoc]) VALUES (N'GV0004', N'Lam Trung Toan', N'Long Dien B, An Phu', N'0845241566', N'MH0004')
INSERT [dbo].[GIAOVIEN] ([MaGiaoVien], [TenGiaoVien], [DiaChi], [DienThoai], [MaMonHoc]) VALUES (N'GV0005', N'Huynh Tuc Tri', N'Rach Gia, Kien Giang', N'0123456789', N'MH0005')
INSERT [dbo].[GIAOVIEN] ([MaGiaoVien], [TenGiaoVien], [DiaChi], [DienThoai], [MaMonHoc]) VALUES (N'GV0006', N'Le Thi Minh Nguyet', N'000 Long Xuyen, An Giang', N'0123456789', N'MH0006')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0001', N'Nguyen Van Tu', 0, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0005', N'1', N'NN0005', N'2', N'NN0002')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0002', N'Nguyen Ngoc An', 0, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0002', N'1', N'NN0003', N'2', N'NN0001')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0003', N'Le Hoang Anh', 0, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0004', N'1', N'NN0005', N'2', N'NN0005')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0004', N'Huynh Thien Chi', 0, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0003', N'1', N'NN0002', N'2', N'NN0004')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0005', N'Ly Ngoc Duy', 0, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0005', N'1', N'NN0005', N'2', N'NN0002')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0006', N'Huynh Ngoc Diep', 1, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0002', N'1', N'NN0003', N'2', N'NN0001')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0007', N'Tran Thi Hue', 1, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0004', N'1', N'NN0005', N'2', N'NN0005')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0008', N'Nguyen Thanh Huy', 0, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0003', N'1', N'NN0002', N'2', N'NN0004')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0009', N'Tran Phuoc Lap', 0, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0005', N'1', N'NN0005', N'2', N'NN0002')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0010', N'Truong Thi Nga', 1, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0002', N'1', N'NN0003', N'2', N'NN0001')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0011', N'Nguyen Thi Nga', 1, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0004', N'1', N'NN0005', N'2', N'NN0005')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0012', N'Tran Thi Hong Nghi', 1, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0003', N'1', N'NN0002', N'2', N'NN0004')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0013', N'Huynh Thi My Ngoc', 1, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0005', N'1', N'NN0005', N'2', N'NN0002')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0014', N'Tran Thi My Nhan', 1, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0002', N'1', N'NN0003', N'2', N'NN0001')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0015', N'Truong Thi Ngoc Nhung', 1, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0004', N'1', N'NN0005', N'2', N'NN0005')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0016', N'Huynh Quoc Phuong', 0, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0003', N'1', N'NN0002', N'2', N'NN0004')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0017', N'Ly Ngoc Phuong', 1, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0005', N'1', N'NN0005', N'2', N'NN0002')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0018', N'Nguyen Thi Phuong', 1, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0002', N'1', N'NN0003', N'2', N'NN0001')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0019', N'Nguyen Phu Quoc', 0, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0004', N'1', N'NN0005', N'2', N'NN0005')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0020', N'Vo Thien Quoc', 0, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0003', N'1', N'NN0002', N'2', N'NN0004')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0021', N'Tran Van Rang', 0, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0005', N'1', N'NN0005', N'2', N'NN0002')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0022', N'Vo Huu Tanh', 0, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0002', N'1', N'NN0003', N'2', N'NN0001')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0023', N'Le Minh Tam', 0, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0004', N'1', N'NN0005', N'2', N'NN0005')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0024', N'Nguyen Duc Tam', 0, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0003', N'1', N'NN0002', N'2', N'NN0004')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0025', N'Nguyen Thanh Tam', 0, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0005', N'1', N'NN0005', N'2', N'NN0002')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0026', N'Tran Ngoc Minh Tan', 0, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0002', N'1', N'NN0003', N'2', N'NN0001')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0027', N'Duong Kim Thanh', 1, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0004', N'1', N'NN0005', N'2', N'NN0005')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0028', N'Vang Si Thanh', 0, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0003', N'1', N'NN0002', N'2', N'NN0004')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0029', N'Do Thi Bich Thao', 1, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0005', N'1', N'NN0005', N'2', N'NN0002')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0030', N'Ho Minh Thien', 0, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0002', N'1', N'NN0003', N'2', N'NN0001')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0031', N'Nguyen Thi Anh Thu', 1, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0004', N'1', N'NN0005', N'2', N'NN0005')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0032', N'Pham Nguyen B.Trinh', 1, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0003', N'1', N'NN0002', N'2', N'NN0004')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0033', N'Vo Ngoc Trinh', 1, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0005', N'1', N'NN0005', N'2', N'NN0002')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0034', N'Nguyen Huynh Minh Tri', 0, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0002', N'1', N'NN0003', N'2', N'NN0001')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0035', N'Do Xuan Trinh', 0, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0004', N'1', N'NN0005', N'2', N'NN0005')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0036', N'Nguyen Hieu Trung', 0, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0003', N'1', N'NN0002', N'2', N'NN0004')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0037', N'Nguyen Thanh Trung', 0, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0005', N'1', N'NN0005', N'2', N'NN0002')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0038', N'Tran Thanh Truc', 1, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0002', N'1', N'NN0003', N'2', N'NN0001')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0039', N'Cao Minh Tuan', 0, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0004', N'1', N'NN0005', N'2', N'NN0005')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0040', N'Nguyen Hoang Tuan', 0, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0003', N'1', N'NN0002', N'2', N'NN0004')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0041', N'Truong Minh Tuyen', 0, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0005', N'1', N'NN0005', N'2', N'NN0002')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0042', N'Le Thanh Tung', 0, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0002', N'1', N'NN0003', N'2', N'NN0001')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0043', N'Pham Thi Bich Vi', 1, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0004', N'1', N'NN0005', N'2', N'NN0005')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0044', N'Dang Quang Vinh', 0, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0003', N'1', N'NN0002', N'2', N'NN0004')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0045', N'Au Ngoc Vu', 0, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0005', N'1', N'NN0005', N'2', N'NN0002')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0046', N'Ho Thanh Vu', 0, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0002', N'1', N'NN0003', N'2', N'NN0001')
INSERT [dbo].[HOCSINH] ([MaHocSinh], [HoTen], [GioiTinh], [NgaySinh], [NoiSinh], [MaDanToc], [MaTonGiao], [HoTenCha], [MaNNghiepCha], [HoTenMe], [MaNNghiepMe]) VALUES (N'HS0047', N'Phan Quoc Vuong', 0, CAST(N'2002-10-10 00:00:00.000' AS DateTime), N'Thai Nguyen', N'DT0001', N'TG0004', N'1', N'NN0005', N'2', N'NN0005')
INSERT [dbo].[KHOILOP] ([MaKhoiLop], [TenKhoiLop]) VALUES (N'KHOI10', N'Khoi 10')
INSERT [dbo].[KHOILOP] ([MaKhoiLop], [TenKhoiLop]) VALUES (N'KHOI11', N'Khoi 11')
INSERT [dbo].[KHOILOP] ([MaKhoiLop], [TenKhoiLop]) VALUES (N'KHOI12', N'Khoi 12')
INSERT [dbo].[LOAINGUOIDUNG] ([MaLoai], [TenLoaiND]) VALUES (N'LND001', N'Ban giam hieu')
INSERT [dbo].[LOAINGUOIDUNG] ([MaLoai], [TenLoaiND]) VALUES (N'LND002', N'Giao vien')
INSERT [dbo].[LOAINGUOIDUNG] ([MaLoai], [TenLoaiND]) VALUES (N'LND003', N'Nhan vien giao vu')
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoiLop], [MaNamHoc], [SiSo], [MaGiaoVien]) VALUES (N'LOP1010708', N'10A1', N'KHOI10', N'NH0708', 35, N'GV0006')
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoiLop], [MaNamHoc], [SiSo], [MaGiaoVien]) VALUES (N'LOP1010809', N'10A1', N'KHOI10', N'NH0809', 39, N'GV0001')
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoiLop], [MaNamHoc], [SiSo], [MaGiaoVien]) VALUES (N'LOP1020708', N'10A2', N'KHOI10', N'NH0708', 36, N'GV0005')
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoiLop], [MaNamHoc], [SiSo], [MaGiaoVien]) VALUES (N'LOP1020809', N'10A2', N'KHOI10', N'NH0809', 38, N'GV0002')
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoiLop], [MaNamHoc], [SiSo], [MaGiaoVien]) VALUES (N'LOP1030708', N'10A3', N'KHOI10', N'NH0708', 34, N'GV0004')
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoiLop], [MaNamHoc], [SiSo], [MaGiaoVien]) VALUES (N'LOP1030809', N'10A3', N'KHOI10', N'NH0809', 35, N'GV0003')
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoiLop], [MaNamHoc], [SiSo], [MaGiaoVien]) VALUES (N'LOP1110708', N'11A1', N'KHOI11', N'NH0708', 37, N'GV0003')
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoiLop], [MaNamHoc], [SiSo], [MaGiaoVien]) VALUES (N'LOP1110809', N'11A1', N'KHOI11', N'NH0809', 40, N'GV0004')
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoiLop], [MaNamHoc], [SiSo], [MaGiaoVien]) VALUES (N'LOP1120708', N'11A2', N'KHOI11', N'NH0708', 38, N'GV0002')
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoiLop], [MaNamHoc], [SiSo], [MaGiaoVien]) VALUES (N'LOP1120809', N'11A2', N'KHOI11', N'NH0809', 38, N'GV0005')
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoiLop], [MaNamHoc], [SiSo], [MaGiaoVien]) VALUES (N'LOP1210708', N'12A1', N'KHOI12', N'NH0708', 39, N'GV0001')
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoiLop], [MaNamHoc], [SiSo], [MaGiaoVien]) VALUES (N'LOP1210809', N'12A1', N'KHOI12', N'NH0809', 38, N'GV0006')
INSERT [dbo].[MONHOC] ([MaMonHoc], [TenMonHoc], [SoTiet], [HeSo]) VALUES (N'MH0001', N'Toan Hoc', 90, 2)
INSERT [dbo].[MONHOC] ([MaMonHoc], [TenMonHoc], [SoTiet], [HeSo]) VALUES (N'MH0002', N'Vat Ly', 60, 1)
INSERT [dbo].[MONHOC] ([MaMonHoc], [TenMonHoc], [SoTiet], [HeSo]) VALUES (N'MH0003', N'Hoa Hoc', 60, 1)
INSERT [dbo].[MONHOC] ([MaMonHoc], [TenMonHoc], [SoTiet], [HeSo]) VALUES (N'MH0004', N'Sinh Hoc', 60, 1)
INSERT [dbo].[MONHOC] ([MaMonHoc], [TenMonHoc], [SoTiet], [HeSo]) VALUES (N'MH0005', N'Ngu Van', 90, 2)
INSERT [dbo].[MONHOC] ([MaMonHoc], [TenMonHoc], [SoTiet], [HeSo]) VALUES (N'MH0006', N'Lich Su', 45, 1)
INSERT [dbo].[MONHOC] ([MaMonHoc], [TenMonHoc], [SoTiet], [HeSo]) VALUES (N'MH0007', N'Dia Ly', 45, 1)
INSERT [dbo].[MONHOC] ([MaMonHoc], [TenMonHoc], [SoTiet], [HeSo]) VALUES (N'MH0008', N'Anh Van', 45, 1)
INSERT [dbo].[MONHOC] ([MaMonHoc], [TenMonHoc], [SoTiet], [HeSo]) VALUES (N'MH0009', N'GD Cong Dan', 30, 1)
INSERT [dbo].[MONHOC] ([MaMonHoc], [TenMonHoc], [SoTiet], [HeSo]) VALUES (N'MH0010', N'Tin Hoc', 30, 1)
INSERT [dbo].[MONHOC] ([MaMonHoc], [TenMonHoc], [SoTiet], [HeSo]) VALUES (N'MH0011', N'The Duc', 30, 1)
INSERT [dbo].[MONHOC] ([MaMonHoc], [TenMonHoc], [SoTiet], [HeSo]) VALUES (N'MH0012', N'Quoc Phong', 30, 1)
INSERT [dbo].[MONHOC] ([MaMonHoc], [TenMonHoc], [SoTiet], [HeSo]) VALUES (N'MH0013', N'Cong Nghe', 30, 1)
INSERT [dbo].[NAMHOC] ([MaNamHoc], [TenNamHoc]) VALUES (N'NH0708', N'2007 - 2008')
INSERT [dbo].[NAMHOC] ([MaNamHoc], [TenNamHoc]) VALUES (N'NH0809', N'2008 - 2009')
INSERT [dbo].[NGHENGHIEP] ([MaNghe], [TenNghe]) VALUES (N'NN0001', N'Noi tro')
INSERT [dbo].[NGHENGHIEP] ([MaNghe], [TenNghe]) VALUES (N'NN0002', N'Giao vien')
INSERT [dbo].[NGHENGHIEP] ([MaNghe], [TenNghe]) VALUES (N'NN0003', N'Cong nhan')
INSERT [dbo].[NGHENGHIEP] ([MaNghe], [TenNghe]) VALUES (N'NN0004', N'Lam ruong')
INSERT [dbo].[NGHENGHIEP] ([MaNghe], [TenNghe]) VALUES (N'NN0005', N'Buon ban')
INSERT [dbo].[NGUOIDUNG] ([MaND], [MaLoai], [TenND], [TenDNhap], [MatKhau]) VALUES (N'ND0001', N'LND001', N'Le Hoang Huynh', N'admin', N'admin')
INSERT [dbo].[NGUOIDUNG] ([MaND], [MaLoai], [TenND], [TenDNhap], [MatKhau]) VALUES (N'ND0002', N'LND002', N'Nguyen Trong Long', N'long', N'long')
INSERT [dbo].[NGUOIDUNG] ([MaND], [MaLoai], [TenND], [TenDNhap], [MatKhau]) VALUES (N'ND0003', N'LND003', N'Bui Thanh Hoang', N'hoang', N'hoang')
SET IDENTITY_INSERT [dbo].[PHANCONG] ON 

INSERT [dbo].[PHANCONG] ([STT], [MaNamHoc], [MaLop], [MaMonHoc], [MaGiaoVien]) VALUES (1, N'NH0708', N'LOP1010708', N'MH0001', N'GV0001')
INSERT [dbo].[PHANCONG] ([STT], [MaNamHoc], [MaLop], [MaMonHoc], [MaGiaoVien]) VALUES (2, N'NH0708', N'LOP1010708', N'MH0002', N'GV0002')
INSERT [dbo].[PHANCONG] ([STT], [MaNamHoc], [MaLop], [MaMonHoc], [MaGiaoVien]) VALUES (3, N'NH0708', N'LOP1010708', N'MH0003', N'GV0003')
INSERT [dbo].[PHANCONG] ([STT], [MaNamHoc], [MaLop], [MaMonHoc], [MaGiaoVien]) VALUES (4, N'NH0708', N'LOP1010708', N'MH0004', N'GV0004')
INSERT [dbo].[PHANCONG] ([STT], [MaNamHoc], [MaLop], [MaMonHoc], [MaGiaoVien]) VALUES (5, N'NH0708', N'LOP1020708', N'MH0001', N'GV0001')
INSERT [dbo].[PHANCONG] ([STT], [MaNamHoc], [MaLop], [MaMonHoc], [MaGiaoVien]) VALUES (6, N'NH0708', N'LOP1020708', N'MH0002', N'GV0002')
INSERT [dbo].[PHANCONG] ([STT], [MaNamHoc], [MaLop], [MaMonHoc], [MaGiaoVien]) VALUES (7, N'NH0708', N'LOP1020708', N'MH0003', N'GV0003')
INSERT [dbo].[PHANCONG] ([STT], [MaNamHoc], [MaLop], [MaMonHoc], [MaGiaoVien]) VALUES (8, N'NH0708', N'LOP1020708', N'MH0004', N'GV0004')
INSERT [dbo].[PHANCONG] ([STT], [MaNamHoc], [MaLop], [MaMonHoc], [MaGiaoVien]) VALUES (9, N'NH0708', N'LOP1110708', N'MH0001', N'GV0001')
INSERT [dbo].[PHANCONG] ([STT], [MaNamHoc], [MaLop], [MaMonHoc], [MaGiaoVien]) VALUES (10, N'NH0708', N'LOP1110708', N'MH0002', N'GV0002')
INSERT [dbo].[PHANCONG] ([STT], [MaNamHoc], [MaLop], [MaMonHoc], [MaGiaoVien]) VALUES (11, N'NH0708', N'LOP1110708', N'MH0003', N'GV0003')
INSERT [dbo].[PHANCONG] ([STT], [MaNamHoc], [MaLop], [MaMonHoc], [MaGiaoVien]) VALUES (12, N'NH0708', N'LOP1110708', N'MH0004', N'GV0004')
SET IDENTITY_INSERT [dbo].[PHANCONG] OFF
INSERT [dbo].[QUYDINH] ([TuoiCanDuoi], [TuoiCanTren], [SiSoCanDuoi], [SiSoCanTren], [ThangDiem], [TenTruong], [DiaChiTruong]) VALUES (15, 20, 30, 40, 10, N'THPT Vo Nhai', N'Lau Thuong - Vo Nhai - Thai Nguyen')
INSERT [dbo].[TONGIAO] ([MaTonGiao], [TenTonGiao]) VALUES (N'TG0001', N'Khong')
INSERT [dbo].[TONGIAO] ([MaTonGiao], [TenTonGiao]) VALUES (N'TG0002', N'Phat')
INSERT [dbo].[TONGIAO] ([MaTonGiao], [TenTonGiao]) VALUES (N'TG0003', N'PG Hoa Hao')
INSERT [dbo].[TONGIAO] ([MaTonGiao], [TenTonGiao]) VALUES (N'TG0004', N'Thien Chua')
INSERT [dbo].[TONGIAO] ([MaTonGiao], [TenTonGiao]) VALUES (N'TG0005', N'Tin Lanh')
ALTER TABLE [dbo].[GIAOVIEN]  WITH CHECK ADD  CONSTRAINT [F_GV_MH] FOREIGN KEY([MaMonHoc])
REFERENCES [dbo].[MONHOC] ([MaMonHoc])
GO
ALTER TABLE [dbo].[GIAOVIEN] CHECK CONSTRAINT [F_GV_MH]
GO
ALTER TABLE [dbo].[HOCSINH]  WITH CHECK ADD  CONSTRAINT [F_HS_DT] FOREIGN KEY([MaDanToc])
REFERENCES [dbo].[DANTOC] ([MaDanToc])
GO
ALTER TABLE [dbo].[HOCSINH] CHECK CONSTRAINT [F_HS_DT]
GO
ALTER TABLE [dbo].[HOCSINH]  WITH CHECK ADD  CONSTRAINT [F_HS_NNC] FOREIGN KEY([MaNNghiepCha])
REFERENCES [dbo].[NGHENGHIEP] ([MaNghe])
GO
ALTER TABLE [dbo].[HOCSINH] CHECK CONSTRAINT [F_HS_NNC]
GO
ALTER TABLE [dbo].[HOCSINH]  WITH CHECK ADD  CONSTRAINT [F_HS_NNM] FOREIGN KEY([MaNNghiepMe])
REFERENCES [dbo].[NGHENGHIEP] ([MaNghe])
GO
ALTER TABLE [dbo].[HOCSINH] CHECK CONSTRAINT [F_HS_NNM]
GO
ALTER TABLE [dbo].[HOCSINH]  WITH CHECK ADD  CONSTRAINT [F_HS_TG] FOREIGN KEY([MaTonGiao])
REFERENCES [dbo].[TONGIAO] ([MaTonGiao])
GO
ALTER TABLE [dbo].[HOCSINH] CHECK CONSTRAINT [F_HS_TG]
GO
ALTER TABLE [dbo].[LOP]  WITH CHECK ADD  CONSTRAINT [F_LOP_GV] FOREIGN KEY([MaGiaoVien])
REFERENCES [dbo].[GIAOVIEN] ([MaGiaoVien])
GO
ALTER TABLE [dbo].[LOP] CHECK CONSTRAINT [F_LOP_GV]
GO
ALTER TABLE [dbo].[LOP]  WITH CHECK ADD  CONSTRAINT [F_LOP_KL] FOREIGN KEY([MaKhoiLop])
REFERENCES [dbo].[KHOILOP] ([MaKhoiLop])
GO
ALTER TABLE [dbo].[LOP] CHECK CONSTRAINT [F_LOP_KL]
GO
ALTER TABLE [dbo].[LOP]  WITH CHECK ADD  CONSTRAINT [F_LOP_NH] FOREIGN KEY([MaNamHoc])
REFERENCES [dbo].[NAMHOC] ([MaNamHoc])
GO
ALTER TABLE [dbo].[LOP] CHECK CONSTRAINT [F_LOP_NH]
GO
ALTER TABLE [dbo].[NGUOIDUNG]  WITH CHECK ADD  CONSTRAINT [F_ND_LND] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LOAINGUOIDUNG] ([MaLoai])
GO
ALTER TABLE [dbo].[NGUOIDUNG] CHECK CONSTRAINT [F_ND_LND]
GO
ALTER TABLE [dbo].[PHANCONG]  WITH CHECK ADD  CONSTRAINT [F_PC_NH] FOREIGN KEY([MaNamHoc])
REFERENCES [dbo].[NAMHOC] ([MaNamHoc])
GO
ALTER TABLE [dbo].[PHANCONG] CHECK CONSTRAINT [F_PC_NH]
GO
ALTER TABLE [dbo].[PHANCONG]  WITH CHECK ADD  CONSTRAINT [P_PC_GV] FOREIGN KEY([MaGiaoVien])
REFERENCES [dbo].[GIAOVIEN] ([MaGiaoVien])
GO
ALTER TABLE [dbo].[PHANCONG] CHECK CONSTRAINT [P_PC_GV]
GO
ALTER TABLE [dbo].[PHANCONG]  WITH CHECK ADD  CONSTRAINT [P_PC_LOP] FOREIGN KEY([MaLop])
REFERENCES [dbo].[LOP] ([MaLop])
GO
ALTER TABLE [dbo].[PHANCONG] CHECK CONSTRAINT [P_PC_LOP]
GO
ALTER TABLE [dbo].[PHANCONG]  WITH CHECK ADD  CONSTRAINT [P_PC_MH] FOREIGN KEY([MaMonHoc])
REFERENCES [dbo].[MONHOC] ([MaMonHoc])
GO
ALTER TABLE [dbo].[PHANCONG] CHECK CONSTRAINT [P_PC_MH]
GO
