﻿USE [WebDatLichKhamBenh]
GO
/****** Object:  Table [dbo].[CHUCVU]    Script Date: 6/20/2017 11:37:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHUCVU](
	[ID] [varchar](5) NOT NULL,
	[CHUCVU] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHANQUYEN]    Script Date: 6/20/2017 11:37:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHANQUYEN](
	[IDCHUCVU] [varchar](5) NOT NULL,
	[IDMENU] [varchar](5) NOT NULL,
 CONSTRAINT [PR_PHANQUYEN] PRIMARY KEY CLUSTERED 
(
	[IDCHUCVU] ASC,
	[IDMENU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 6/20/2017 11:37:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[HOTEN] [nvarchar](100) NOT NULL,
	[NGAYSINH] [nvarchar](50) NOT NULL,
	[GIOITINH] [nvarchar](3) NOT NULL,
	[SODT] [varchar](11) NOT NULL,
	[DIACHI] [nvarchar](200) NOT NULL,
	[EMAIL] [nvarchar](100) NOT NULL,
	[MATKHAU] [varchar](100) NOT NULL,
	[IDTAIKHOAN] [nvarchar](50) NOT NULL,
	[IDCHUCVU] [nvarchar](50) NOT NULL,
CONSTRAINT [PK_TAIKHOAN] PRIMARY KEY CLUSTERED 
(
	[IDTAIKHOAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

--Tai khoan nhan vien
INSERT INTO TAIKHOAN(HOTEN, NGAYSINH,GIOITINH,SODT,DIACHI,EMAIL,MATKHAU,IDTAIKHOAN, IDCHUCVU) VALUES(N'Admin', '1996-01-10', N'Nam',
 '0969696969', N'Thành Phố', 'admin@gmail.com', '123456','TK14130204','QT');
 INSERT INTO TAIKHOAN(HOTEN, NGAYSINH,GIOITINH,SODT,DIACHI,EMAIL,MATKHAU,IDTAIKHOAN,IDCHUCVU) VALUES(N'Bác sĩ', '1996-01-10', N'Nữ',
 '0969696969', N'Thành Phố', 'bacsi@gmail.com', '123456','TK14130205','BS');
 INSERT INTO TAIKHOAN(HOTEN, NGAYSINH,GIOITINH,SODT,DIACHI,EMAIL,MATKHAU,IDTAIKHOAN,IDCHUCVU) VALUES(N'Điều hành', '1996-01-10', N'Nữ',
 '0969696969', N'Thành Phố', 'giamdoc@gmail.com', '123456','TK14130206','ĐH');
 INSERT INTO TAIKHOAN(HOTEN, NGAYSINH,GIOITINH,SODT,DIACHI,EMAIL,MATKHAU,IDTAIKHOAN,IDCHUCVU) VALUES(N'Trợ lý', '1996-01-10', N'Nam',
 '0969696969', N'Thành Phố', 'troly@gmail.com', '123456','TK14130207','TL');

 --chuc vu
INSERT INTO CHUCVU(ID,CHUCVU) VALUES('QT',N'Quản trị');
INSERT INTO CHUCVU(ID,CHUCVU) VALUES('BS',N'Bác sĩ');
INSERT INTO CHUCVU(ID,CHUCVU) VALUES('ĐH',N'Ban điều hành');
INSERT INTO CHUCVU(ID,CHUCVU) VALUES('TL',N'Trợ lý');

--phan quyen
INSERT INTO PHANQUYEN VALUES('QT','1');
INSERT INTO PHANQUYEN VALUES('QT','2');
INSERT INTO PHANQUYEN VALUES('QT','3');
INSERT INTO PHANQUYEN VALUES('QT','4');

INSERT INTO PHANQUYEN VALUES('BS','1');
INSERT INTO PHANQUYEN VALUES('BS','3');

INSERT INTO PHANQUYEN VALUES('ĐH','1');
INSERT INTO PHANQUYEN VALUES('ĐH','2');
INSERT INTO PHANQUYEN VALUES('ĐH','3');

INSERT INTO PHANQUYEN VALUES('TL','3');