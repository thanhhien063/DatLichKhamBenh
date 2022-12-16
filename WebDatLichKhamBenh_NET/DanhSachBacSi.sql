USE [WebDatLichKhamBenh]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[danhsachbacsi](
	[mabacsi] [nvarchar](50) NOT NULL,
	[hovaten] [nvarchar](50) NULL ,
	[chucvu] [nvarchar](50) NULL,
	sdt [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
	cmnd [nvarchar](50) NULL,
	
 CONSTRAINT [PK_danhsachbacsi] PRIMARY KEY CLUSTERED 
(
	[mabacsi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

select * from danhsachbacsi
