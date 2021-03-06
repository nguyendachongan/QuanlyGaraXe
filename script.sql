USE [QLGRXH]
GO
/****** Object:  Table [dbo].[Chitiet_HD]    Script Date: 10/22/2016 12:56:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chitiet_HD](
	[soHD] [nchar](50) NOT NULL,
	[maCV] [nchar](50) NOT NULL,
	[triGia_CV] [money] NOT NULL,
	[maTho] [nchar](50) NOT NULL,
	[khoanTho] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[soHD] ASC,
	[maCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cong_Viec]    Script Date: 10/22/2016 12:56:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cong_Viec](
	[MACV] [nchar](50) NOT NULL,
	[NOIDUNGCV] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MACV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hop_Dong]    Script Date: 10/22/2016 12:56:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hop_Dong](
	[soHD] [nchar](50) NOT NULL,
	[maKH] [nchar](50) NOT NULL,
	[tenKH] [nvarchar](50) NOT NULL,
	[diaChi] [nvarchar](100) NOT NULL,
	[ngayHD] [datetime] NOT NULL,
	[soXe] [nchar](50) NOT NULL,
	[triGiaHD] [money] NOT NULL,
	[ng_Giao_DK] [datetime] NOT NULL,
	[ng_NgThu] [datetime] NOT NULL,
 CONSTRAINT [PK__Hop_Dong__A7FF3B41DACC8D0F] PRIMARY KEY CLUSTERED 
(
	[soHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Khach_Hang]    Script Date: 10/22/2016 12:56:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khach_Hang](
	[maKH] [nchar](50) NOT NULL,
	[tenKH] [nvarchar](50) NOT NULL,
	[diaChi] [nvarchar](50) NOT NULL,
	[soCMND] [nchar](20) NOT NULL,
	[soDT] [nchar](20) NULL,
 CONSTRAINT [PK__Khach_Ha__603F592C830F3DA4] PRIMARY KEY CLUSTERED 
(
	[maKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Phieu_thu]    Script Date: 10/22/2016 12:56:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phieu_thu](
	[soPH] [nchar](50) NOT NULL,
	[ngayPH] [datetime] NOT NULL,
	[soHD] [nchar](50) NOT NULL,
	[hoTen] [nvarchar](50) NOT NULL,
	[soTienThu] [money] NOT NULL,
 CONSTRAINT [PK__Phieu_th__A7FCFA4762FA843C] PRIMARY KEY CLUSTERED 
(
	[soPH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tho]    Script Date: 10/22/2016 12:56:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tho](
	[maTho] [nchar](50) NOT NULL,
	[tenTho] [nvarchar](50) NOT NULL,
	[nhom] [nchar](50) NOT NULL,
	[nhom_Truong] [nchar](50) NOT NULL,
 CONSTRAINT [PK__Tho__5824820E36694398] PRIMARY KEY CLUSTERED 
(
	[maTho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Chitiet_HD] ([soHD], [maCV], [triGia_CV], [maTho], [khoanTho]) VALUES (N'HD1                                               ', N'CV07                                              ', 40000000.0000, N'01                                                ', 30000000.0000)
INSERT [dbo].[Chitiet_HD] ([soHD], [maCV], [triGia_CV], [maTho], [khoanTho]) VALUES (N'HD2                                               ', N'CV01                                              ', 60000000.0000, N'04                                                ', 50000000.0000)
INSERT [dbo].[Chitiet_HD] ([soHD], [maCV], [triGia_CV], [maTho], [khoanTho]) VALUES (N'HD3                                               ', N'CV04                                              ', 60000000.0000, N'03                                                ', 50000000.0000)
INSERT [dbo].[Chitiet_HD] ([soHD], [maCV], [triGia_CV], [maTho], [khoanTho]) VALUES (N'HD4                                               ', N'CV07                                              ', 60000000.0000, N'05                                                ', 50000000.0000)
INSERT [dbo].[Chitiet_HD] ([soHD], [maCV], [triGia_CV], [maTho], [khoanTho]) VALUES (N'HD5                                               ', N'CV06                                              ', 60000000.0000, N'07                                                ', 50000000.0000)
INSERT [dbo].[Chitiet_HD] ([soHD], [maCV], [triGia_CV], [maTho], [khoanTho]) VALUES (N'HD6                                               ', N'CV03                                              ', 60000000.0000, N'04                                                ', 50000000.0000)
INSERT [dbo].[Chitiet_HD] ([soHD], [maCV], [triGia_CV], [maTho], [khoanTho]) VALUES (N'HD7                                               ', N'CV04                                              ', 60000000.0000, N'04                                                ', 50000000.0000)
INSERT [dbo].[Chitiet_HD] ([soHD], [maCV], [triGia_CV], [maTho], [khoanTho]) VALUES (N'HD8                                               ', N'CV07                                              ', 60000000.0000, N'04                                                ', 50000000.0000)
INSERT [dbo].[Cong_Viec] ([MACV], [NOIDUNGCV]) VALUES (N'CV01                                              ', N'Thay khung xe')
INSERT [dbo].[Cong_Viec] ([MACV], [NOIDUNGCV]) VALUES (N'CV02                                              ', N'Vá bánh xe')
INSERT [dbo].[Cong_Viec] ([MACV], [NOIDUNGCV]) VALUES (N'CV03                                              ', N'Tháo lắp phụ kiện')
INSERT [dbo].[Cong_Viec] ([MACV], [NOIDUNGCV]) VALUES (N'CV04                                              ', N'Tiếp nhận và kiểm tra')
INSERT [dbo].[Cong_Viec] ([MACV], [NOIDUNGCV]) VALUES (N'CV05                                              ', N'Bảo trì')
INSERT [dbo].[Cong_Viec] ([MACV], [NOIDUNGCV]) VALUES (N'CV06                                              ', N'Trang trí nội thất')
INSERT [dbo].[Cong_Viec] ([MACV], [NOIDUNGCV]) VALUES (N'CV07                                              ', N'Làm đồng và sơn xe')
INSERT [dbo].[Hop_Dong] ([soHD], [maKH], [tenKH], [diaChi], [ngayHD], [soXe], [triGiaHD], [ng_Giao_DK], [ng_NgThu]) VALUES (N'HD1                                               ', N'01                                                ', N'Trần Thị Hương', N'123 Nguyễn Văn Bảo Gò Vấp TpHCM', CAST(0x0000A67F00000000 AS DateTime), N'25641                                             ', 50000000.0000, CAST(0x0000A6A800000000 AS DateTime), CAST(0x0000A6AF00000000 AS DateTime))
INSERT [dbo].[Hop_Dong] ([soHD], [maKH], [tenKH], [diaChi], [ngayHD], [soXe], [triGiaHD], [ng_Giao_DK], [ng_NgThu]) VALUES (N'HD2                                               ', N'02                                                ', N'Nguyễn Bảo Lâm', N'12B/3 Nguyễn Văn Lượng Gò Vấp TpHCM', CAST(0x0000A66000000000 AS DateTime), N'25641                                             ', 60000000.0000, CAST(0x0000A68A00000000 AS DateTime), CAST(0x0000A69100000000 AS DateTime))
INSERT [dbo].[Hop_Dong] ([soHD], [maKH], [tenKH], [diaChi], [ngayHD], [soXe], [triGiaHD], [ng_Giao_DK], [ng_NgThu]) VALUES (N'HD3                                               ', N'03                                                ', N'Trần Văn Linh', N'32 Nguyễn Văn Bảo Gò Vấp TpHCM', CAST(0x0000A69B00000000 AS DateTime), N'25641                                             ', 70000000.0000, CAST(0x0000A6B300000000 AS DateTime), CAST(0x0000A6B500000000 AS DateTime))
INSERT [dbo].[Hop_Dong] ([soHD], [maKH], [tenKH], [diaChi], [ngayHD], [soXe], [triGiaHD], [ng_Giao_DK], [ng_NgThu]) VALUES (N'HD4                                               ', N'04                                                ', N'Nguyễn Anh Quốc', N'32A Huỳnh An Khương Gò Vấp TpHCM', CAST(0x0000A69D00000000 AS DateTime), N'25641                                             ', 80000000.0000, CAST(0x0000A6A800000000 AS DateTime), CAST(0x0000A6A900000000 AS DateTime))
INSERT [dbo].[Hop_Dong] ([soHD], [maKH], [tenKH], [diaChi], [ngayHD], [soXe], [triGiaHD], [ng_Giao_DK], [ng_NgThu]) VALUES (N'HD5                                               ', N'05                                                ', N'Phan Công Anh', N'32 Lê lợi Gò Vấp TpHCM', CAST(0x0000A6A700000000 AS DateTime), N'25641                                             ', 50000000.0000, CAST(0x0000A6BA00000000 AS DateTime), CAST(0x0000A6BA00000000 AS DateTime))
INSERT [dbo].[Hop_Dong] ([soHD], [maKH], [tenKH], [diaChi], [ngayHD], [soXe], [triGiaHD], [ng_Giao_DK], [ng_NgThu]) VALUES (N'HD6                                               ', N'06                                                ', N'nguyễn Minh Nhật', N'32 Phạn Văn Đồng Gò Vấp TpHCM', CAST(0x0000A69D00000000 AS DateTime), N'25641                                             ', 40000000.0000, CAST(0x0000A69200000000 AS DateTime), CAST(0x0000A69600000000 AS DateTime))
INSERT [dbo].[Hop_Dong] ([soHD], [maKH], [tenKH], [diaChi], [ngayHD], [soXe], [triGiaHD], [ng_Giao_DK], [ng_NgThu]) VALUES (N'HD7                                               ', N'09                                                ', N'Nguyễn Đất Hồng Ân', N'N32 Nguy?n Ki?m Gò V?p TpHCM', CAST(0x0000A69100000000 AS DateTime), N'25641                                             ', 30000000.0000, CAST(0x0000A69800000000 AS DateTime), CAST(0x0000A69B00000000 AS DateTime))
INSERT [dbo].[Hop_Dong] ([soHD], [maKH], [tenKH], [diaChi], [ngayHD], [soXe], [triGiaHD], [ng_Giao_DK], [ng_NgThu]) VALUES (N'HD8                                               ', N'08                                                ', N'Nguyễn Ngọc Hóa', N'32 Tân Sơn Hòa Tân Bình TpHCM', CAST(0x0000A69D00000000 AS DateTime), N'25641                                             ', 30000000.0000, CAST(0x0000A6A500000000 AS DateTime), CAST(0x0000A6A700000000 AS DateTime))
INSERT [dbo].[Khach_Hang] ([maKH], [tenKH], [diaChi], [soCMND], [soDT]) VALUES (N'01                                                ', N'Trần Thị Hương', N'123 Nguyễn Văn Bảo Gò Vấp TpHCM', N'0934511223          ', N'021356874           ')
INSERT [dbo].[Khach_Hang] ([maKH], [tenKH], [diaChi], [soCMND], [soDT]) VALUES (N'02                                                ', N'Nguyễn Bảo Lâm', N'12B/3 Nguyễn Văn Lượng Gò Vấp TpHCM', N'01263547852         ', N'201325698           ')
INSERT [dbo].[Khach_Hang] ([maKH], [tenKH], [diaChi], [soCMND], [soDT]) VALUES (N'03                                                ', N'Trần Văn Linh', N'32 Nguyễn Văn Bảo Gò Vấp TpHCM', N'01235648974         ', N'230165894           ')
INSERT [dbo].[Khach_Hang] ([maKH], [tenKH], [diaChi], [soCMND], [soDT]) VALUES (N'04                                                ', N'Nguyễn Anh Quốc', N'32A Huỳnh An Khương Gò Vấp TpHCM', N'0321562481          ', N'125034689           ')
INSERT [dbo].[Khach_Hang] ([maKH], [tenKH], [diaChi], [soCMND], [soDT]) VALUES (N'05                                                ', N'Phan Công Anh', N'32 Lê lợi Gò Vấp TpHCM', N'0932145860          ', N'123568974           ')
INSERT [dbo].[Khach_Hang] ([maKH], [tenKH], [diaChi], [soCMND], [soDT]) VALUES (N'06                                                ', N'nguyễn Minh Nhật', N'32 Phạn Văn Đồng Gò Vấp TpHCM', N'01235645614         ', N'152397452           ')
INSERT [dbo].[Khach_Hang] ([maKH], [tenKH], [diaChi], [soCMND], [soDT]) VALUES (N'07                                                ', N'Trần Hữu Luân', N'32 Hoàng Văn Thụ Tân Bình TpHCM', N'0963214520          ', N'15232489            ')
INSERT [dbo].[Khach_Hang] ([maKH], [tenKH], [diaChi], [soCMND], [soDT]) VALUES (N'08                                                ', N'Nguyễn Ngọc Hóa', N'32 Tân Sơn Hòa Tân Bình TpHCM', N'01832956214         ', N'523016485           ')
INSERT [dbo].[Khach_Hang] ([maKH], [tenKH], [diaChi], [soCMND], [soDT]) VALUES (N'09                                                ', N'Nguyễn Đất Hồng Ân', N'N32 Nguy?n Ki?m Gò V?p TpHCM', N'0932569874          ', N'564897263           ')
INSERT [dbo].[Phieu_thu] ([soPH], [ngayPH], [soHD], [hoTen], [soTienThu]) VALUES (N'P1                                                ', CAST(0x0000A6AF00000000 AS DateTime), N'HD1                                               ', N'Trần Thị Hương', 50000000.0000)
INSERT [dbo].[Phieu_thu] ([soPH], [ngayPH], [soHD], [hoTen], [soTienThu]) VALUES (N'P2                                                ', CAST(0x0000A69100000000 AS DateTime), N'HD2                                               ', N'Nguyễn Bảo Lâm', 60000000.0000)
INSERT [dbo].[Phieu_thu] ([soPH], [ngayPH], [soHD], [hoTen], [soTienThu]) VALUES (N'P3                                                ', CAST(0x0000A6B500000000 AS DateTime), N'HD3                                               ', N'Trần Văn Tín', 70000000.0000)
INSERT [dbo].[Phieu_thu] ([soPH], [ngayPH], [soHD], [hoTen], [soTienThu]) VALUES (N'P4                                                ', CAST(0x0000A6A900000000 AS DateTime), N'HD4                                               ', N'Nguyễn Anh Quốc', 80000000.0000)
INSERT [dbo].[Phieu_thu] ([soPH], [ngayPH], [soHD], [hoTen], [soTienThu]) VALUES (N'P5                                                ', CAST(0x0000A6BA00000000 AS DateTime), N'HD5                                               ', N'Phan Công Em', 50000000.0000)
INSERT [dbo].[Phieu_thu] ([soPH], [ngayPH], [soHD], [hoTen], [soTienThu]) VALUES (N'P6                                                ', CAST(0x0000A69600000000 AS DateTime), N'HD6                                               ', N'Nguyễn Thị Thảo', 40000000.0000)
INSERT [dbo].[Tho] ([maTho], [tenTho], [nhom], [nhom_Truong]) VALUES (N'01                                                ', N'Nguyễn Văn Nam', N'01                                                ', N'01                                                ')
INSERT [dbo].[Tho] ([maTho], [tenTho], [nhom], [nhom_Truong]) VALUES (N'02                                                ', N'Trần Anh', N'01                                                ', N'01                                                ')
INSERT [dbo].[Tho] ([maTho], [tenTho], [nhom], [nhom_Truong]) VALUES (N'03                                                ', N'Nguyễn Vũ', N'01                                                ', N'01                                                ')
INSERT [dbo].[Tho] ([maTho], [tenTho], [nhom], [nhom_Truong]) VALUES (N'04                                                ', N'Nguyễn Minh Hùng', N'02                                                ', N'04                                                ')
INSERT [dbo].[Tho] ([maTho], [tenTho], [nhom], [nhom_Truong]) VALUES (N'05                                                ', N'Nguyễn Thành', N'02                                                ', N'04                                                ')
INSERT [dbo].[Tho] ([maTho], [tenTho], [nhom], [nhom_Truong]) VALUES (N'06                                                ', N'Trần Hoàng', N'02                                                ', N'04                                                ')
INSERT [dbo].[Tho] ([maTho], [tenTho], [nhom], [nhom_Truong]) VALUES (N'07                                                ', N'Lê Thanh Tâm', N'03                                                ', N'07                                                ')
INSERT [dbo].[Tho] ([maTho], [tenTho], [nhom], [nhom_Truong]) VALUES (N'08                                                ', N'Lâm Bình', N'03                                                ', N'07                                                ')
INSERT [dbo].[Tho] ([maTho], [tenTho], [nhom], [nhom_Truong]) VALUES (N'09                                                ', N'Võ Ngọc Hào', N'03                                                ', N'07                                                ')
INSERT [dbo].[Tho] ([maTho], [tenTho], [nhom], [nhom_Truong]) VALUES (N'10                                                ', N'Phan Mạnh Lâm', N'04                                                ', N'10                                                ')
INSERT [dbo].[Tho] ([maTho], [tenTho], [nhom], [nhom_Truong]) VALUES (N'11                                                ', N'Võ Quốc Dương', N'04                                                ', N'10                                                ')
INSERT [dbo].[Tho] ([maTho], [tenTho], [nhom], [nhom_Truong]) VALUES (N'12                                                ', N'Châu Minh Tuấn', N'04                                                ', N'10                                                ')
INSERT [dbo].[Tho] ([maTho], [tenTho], [nhom], [nhom_Truong]) VALUES (N'13                                                ', N'Vũ Đình Ân', N'05                                                ', N'13                                                ')
INSERT [dbo].[Tho] ([maTho], [tenTho], [nhom], [nhom_Truong]) VALUES (N'14                                                ', N'Lương Gia Thuận', N'05                                                ', N'13                                                ')
INSERT [dbo].[Tho] ([maTho], [tenTho], [nhom], [nhom_Truong]) VALUES (N'15                                                ', N'Lê Tất Thạnh', N'05                                                ', N'13                                                ')
ALTER TABLE [dbo].[Chitiet_HD]  WITH CHECK ADD  CONSTRAINT [FK__Chitiet_H__MATHO__1CF15040] FOREIGN KEY([maTho])
REFERENCES [dbo].[Tho] ([maTho])
GO
ALTER TABLE [dbo].[Chitiet_HD] CHECK CONSTRAINT [FK__Chitiet_H__MATHO__1CF15040]
GO
ALTER TABLE [dbo].[Chitiet_HD]  WITH CHECK ADD  CONSTRAINT [FK__Chitiet_HD__SOHD__1DE57479] FOREIGN KEY([soHD])
REFERENCES [dbo].[Hop_Dong] ([soHD])
GO
ALTER TABLE [dbo].[Chitiet_HD] CHECK CONSTRAINT [FK__Chitiet_HD__SOHD__1DE57479]
GO
ALTER TABLE [dbo].[Chitiet_HD]  WITH CHECK ADD  CONSTRAINT [FK_Chitiet_HD_Cong_Viec] FOREIGN KEY([maCV])
REFERENCES [dbo].[Cong_Viec] ([MACV])
GO
ALTER TABLE [dbo].[Chitiet_HD] CHECK CONSTRAINT [FK_Chitiet_HD_Cong_Viec]
GO
ALTER TABLE [dbo].[Phieu_thu]  WITH CHECK ADD  CONSTRAINT [FK__Phieu_thu__SOHD__1920BF5C] FOREIGN KEY([soHD])
REFERENCES [dbo].[Hop_Dong] ([soHD])
GO
ALTER TABLE [dbo].[Phieu_thu] CHECK CONSTRAINT [FK__Phieu_thu__SOHD__1920BF5C]
GO
