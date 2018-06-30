USE [transirestoredb]
GO

/****** Object:  Table [dbo].[Product]    Script Date: 30/06/2018 09:31:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Product](
	[prod_id] [int] IDENTITY(1,1) NOT NULL,
	[prod_cat_id] [int] NOT NULL,
	[prod_name] [nvarchar](50) NOT NULL,
	[prod_description] [nvarchar](300) NOT NULL,
	[prod_img_path] [nvarchar](500) NULL,
	[prod_price] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[prod_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category] FOREIGN KEY([prod_id])
REFERENCES [dbo].[Category] ([cat_id])
GO

ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Category]
GO

