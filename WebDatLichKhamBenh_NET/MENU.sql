USE [WebDatLichKhamBenh]
GO
/****** Object:  Table [dbo].[MENU]    Script Date: 6/20/2017 11:37:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MENU](
	[ID] [varchar](5) NOT NULL,
	[NAME] [nvarchar](50) NOT NULL,
	[ICON] [text] NULL,
	[LINK] [text] NULL,
	[NAMECONTROLLER] [text] NULL,
	[IDPARENT] [varchar](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

--Menu
INSERT INTO MENU(ID, NAME, ICON, LINK, NAMECONTROLLER ) VALUES('1', N'Thống Kê','fa fa-dashboard fa-fw','ThongKe','ThongKe');
INSERT INTO MENU(ID, NAME, ICON, LINK, NAMECONTROLLER) VALUES('2', N'Quản lý bác sĩ','fa fa-bar-chart-o fa-fw','BacSi','BacSi');
INSERT INTO MENU(ID, NAME, ICON, LINK, NAMECONTROLLER) VALUES('3', N'Quản lý lịch khám','fa fa-calendar','LichKham','LichKham');
INSERT INTO MENU(ID, NAME, ICON, LINK, NAMECONTROLLER) VALUES('4', N'Quản lý tài khoản','fa fa-bar-chart-o fa-fw','TaiKhoan','TaiKhoan');

INSERT INTO MENU(ID, NAME, ICON, LINK, NAMECONTROLLER,IDPARENT) VALUES('5', N'Danh sách bác sĩ','fa fa-server','BacSi','BacSi','2');
INSERT INTO MENU(ID, NAME, ICON, LINK, NAMECONTROLLER,IDPARENT) VALUES('6', N'Thêm bác sĩ','fa fa-plus-square','Create','BacSi','2');

INSERT INTO MENU(ID, NAME, ICON, LINK, NAMECONTROLLER,IDPARENT) VALUES('7', N'Danh sách lịch khám','fa fa-server','LichKham','LichKham','3');
INSERT INTO MENU(ID, NAME, ICON, LINK, NAMECONTROLLER,IDPARENT) VALUES('8', N'Thêm lịch khám','fa fa-plus-square','Create','LichKham','3');

INSERT INTO MENU(ID, NAME, ICON, LINK, NAMECONTROLLER,IDPARENT) VALUES('9', N'Tài khoản','fa fa-server','TaiKhoan','TaiKhoan','4');
INSERT INTO MENU(ID, NAME, ICON, LINK, NAMECONTROLLER,IDPARENT) VALUES('10', N'Thêm tài khoản','fa fa-plus-square','Create','TaiKhoan','4');
INSERT INTO MENU(ID, NAME, ICON, LINK, NAMECONTROLLER,IDPARENT) VALUES('11', N'Bảng thống kê','fa fa-plus-square','ThongKe','ThongKe','1');