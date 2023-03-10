USE [WebDatLichKhamBenh]
GO
/****** Object:  Table [dbo].[datlichhen]    Script Date: 6/17/2017 3:46:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[datlichhen](
	[maKhamBenh] [nvarchar](50) NOT NULL,
	[hoVaTen] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[sdt] [nvarchar](50) NULL,
	[ngayThangNamSinh] [nvarchar](50) NULL,
	[gioiTinh] [nvarchar](50) NULL,
	[ngayHen] [nvarchar](50) NULL,
	[noiDung] [nvarchar](50) NULL,
	[trangThai] [nvarchar](50) NULL,
	[IdTaiKhoan] [nvarchar](50) NULL,
 CONSTRAINT [PK_datlichhen] PRIMARY KEY CLUSTERED 
(
	[maKhamBenh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


/*test*/
select * from datlichhen



DELETE FROM datlichhen
WHERE maKhamBenh='s';