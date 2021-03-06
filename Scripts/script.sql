USE [prueba]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 31/03/2017 15:37:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[clientes](
	[nombre] [varchar](50) NULL,
	[cantidadDias] [int] NULL,
	[preciofinal] [int] NULL,
	[tipo] [varchar](50) NULL,
	[FechaDesde] [datetime] NULL,
	[FechaHasta] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[compras]    Script Date: 31/03/2017 15:37:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[compras](
	[nombreprod] [varchar](50) NULL,
	[fechaCompra] [datetime] NULL,
	[precioCompra] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[productos]    Script Date: 31/03/2017 15:37:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[productos](
	[nombre] [varchar](50) NOT NULL,
	[precio] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 31/03/2017 15:37:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuarios](
	[usuario] [varchar](50) NOT NULL,
	[contrasenia] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[compras]  WITH CHECK ADD FOREIGN KEY([nombreprod])
REFERENCES [dbo].[productos] ([nombre])
GO
