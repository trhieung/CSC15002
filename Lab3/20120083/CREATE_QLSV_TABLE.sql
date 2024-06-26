﻿/*-------------------------------------------------------------
	MASV: 20120083
	HO TEN: NGUYỄN TRỌNG HIẾU
	LAB: 03
	NGAY: 04/04/2023

	PREREQUISITES: RUN AFTER FILE BEFORE DOING WITH THIS FILES
	1. CREATE_QLSV_DB.sql
-------------------------------------------------------------*/

USE [QLSV]
GO
/****** Object:  Table [dbo].[LOP]    Script Date: 04/04/2023 10:11:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOP](
	[MALOP] [varchar](20) NOT NULL,
	[TENLOP] [nvarchar](100) NOT NULL,
	[MANV] [varchar](20) NULL,
 CONSTRAINT [PK_LOP] PRIMARY KEY CLUSTERED 
(
	[MALOP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 04/04/2023 10:11:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MANV] [varchar](20) NOT NULL,
	[HOTEN] [nvarchar](100) NOT NULL,
	[EMAIL] [varchar](20) NULL,
	[LUONG] [varbinary](128) NULL,
	[TENDN] [nvarchar](100) NOT NULL,
	[MATKHAU] [varbinary](128) NOT NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SINHVIEN]    Script Date: 04/04/2023 10:11:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SINHVIEN](
	[MASV] [nvarchar](20) NOT NULL,
	[HOTEN] [nvarchar](100) NOT NULL,
	[NGAYSINH] [datetime] NULL,
	[DIACHI] [nvarchar](200) NULL,
	[MALOP] [varchar](20) NULL,
	[TENDN] [nvarchar](100) NOT NULL,
	[MATKHAU] [varbinary](128) NOT NULL,
 CONSTRAINT [PK_SINHVIEN] PRIMARY KEY CLUSTERED 
(
	[MASV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[LOP]  WITH CHECK ADD  CONSTRAINT [FK_LOP_NHANVIEN_MANV] FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
ALTER TABLE [dbo].[LOP] CHECK CONSTRAINT [FK_LOP_NHANVIEN_MANV]
GO
ALTER TABLE [dbo].[SINHVIEN]  WITH CHECK ADD  CONSTRAINT [FK_SINHVIEN_LOP_MALOP] FOREIGN KEY([MALOP])
REFERENCES [dbo].[LOP] ([MALOP])
GO
ALTER TABLE [dbo].[SINHVIEN] CHECK CONSTRAINT [FK_SINHVIEN_LOP_MALOP]
GO