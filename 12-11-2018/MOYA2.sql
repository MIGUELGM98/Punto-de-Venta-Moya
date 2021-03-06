USE [master]
GO
/****** Object:  Database [MOYA2]    Script Date: 11/09/2018 12:18:36 ******/
CREATE DATABASE [MOYA2] ON  PRIMARY 
( NAME = N'MOYA2', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\MOYA2.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MOYA2_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\MOYA2_log.LDF' , SIZE = 576KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MOYA2] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MOYA2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MOYA2] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [MOYA2] SET ANSI_NULLS OFF
GO
ALTER DATABASE [MOYA2] SET ANSI_PADDING OFF
GO
ALTER DATABASE [MOYA2] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [MOYA2] SET ARITHABORT OFF
GO
ALTER DATABASE [MOYA2] SET AUTO_CLOSE ON
GO
ALTER DATABASE [MOYA2] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [MOYA2] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [MOYA2] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [MOYA2] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [MOYA2] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [MOYA2] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [MOYA2] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [MOYA2] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [MOYA2] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [MOYA2] SET  ENABLE_BROKER
GO
ALTER DATABASE [MOYA2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [MOYA2] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [MOYA2] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [MOYA2] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [MOYA2] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [MOYA2] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [MOYA2] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [MOYA2] SET  READ_WRITE
GO
ALTER DATABASE [MOYA2] SET RECOVERY SIMPLE
GO
ALTER DATABASE [MOYA2] SET  MULTI_USER
GO
ALTER DATABASE [MOYA2] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [MOYA2] SET DB_CHAINING OFF
GO
USE [MOYA2]
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 11/09/2018 12:18:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ventas](
	[NumVenta] [int] IDENTITY(1,1) NOT NULL,
	[Total] [int] NULL,
	[Fecha] [varchar](60) NULL,
 CONSTRAINT [PK_Ventas] PRIMARY KEY CLUSTERED 
(
	[NumVenta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Ventas] ON
INSERT [dbo].[Ventas] ([NumVenta], [Total], [Fecha]) VALUES (31, 40, N'29/10/2018')
INSERT [dbo].[Ventas] ([NumVenta], [Total], [Fecha]) VALUES (32, 40, N'29/10/2018')
INSERT [dbo].[Ventas] ([NumVenta], [Total], [Fecha]) VALUES (33, 4000, N'29/10/2018')
INSERT [dbo].[Ventas] ([NumVenta], [Total], [Fecha]) VALUES (34, 40, N'29/10/2018')
INSERT [dbo].[Ventas] ([NumVenta], [Total], [Fecha]) VALUES (35, 85, N'29/10/2018')
INSERT [dbo].[Ventas] ([NumVenta], [Total], [Fecha]) VALUES (36, 40, N'29/10/2018')
INSERT [dbo].[Ventas] ([NumVenta], [Total], [Fecha]) VALUES (37, 48, N'29/10/2018')
INSERT [dbo].[Ventas] ([NumVenta], [Total], [Fecha]) VALUES (38, 115, N'29/10/2018')
INSERT [dbo].[Ventas] ([NumVenta], [Total], [Fecha]) VALUES (39, 70, N'30/10/2018')
INSERT [dbo].[Ventas] ([NumVenta], [Total], [Fecha]) VALUES (40, 61, N'30/10/2018')
INSERT [dbo].[Ventas] ([NumVenta], [Total], [Fecha]) VALUES (41, 40, N'31/10/2018')
INSERT [dbo].[Ventas] ([NumVenta], [Total], [Fecha]) VALUES (42, 85, N'31/10/2018')
INSERT [dbo].[Ventas] ([NumVenta], [Total], [Fecha]) VALUES (43, 800, N'31/10/2018')
INSERT [dbo].[Ventas] ([NumVenta], [Total], [Fecha]) VALUES (44, 75, N'31/10/2018')
INSERT [dbo].[Ventas] ([NumVenta], [Total], [Fecha]) VALUES (45, 40, N'01/11/2018')
INSERT [dbo].[Ventas] ([NumVenta], [Total], [Fecha]) VALUES (46, 800, N'05/11/2018')
INSERT [dbo].[Ventas] ([NumVenta], [Total], [Fecha]) VALUES (47, 0, N'05/11/2018')
SET IDENTITY_INSERT [dbo].[Ventas] OFF
/****** Object:  Table [dbo].[Usuarios]    Script Date: 11/09/2018 12:18:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](50) NULL,
	[Nombres] [varchar](50) NULL,
	[Apellidos] [varchar](80) NULL,
	[Cargo] [varchar](50) NULL,
	[Contraseña] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON
INSERT [dbo].[Usuarios] ([ID], [Usuario], [Nombres], [Apellidos], [Cargo], [Contraseña]) VALUES (1, N'RosaTorres', N'Rosa', N'Torres Briseño', N'Jefe', N'rosa1234')
INSERT [dbo].[Usuarios] ([ID], [Usuario], [Nombres], [Apellidos], [Cargo], [Contraseña]) VALUES (24, N'Brenda', N'BrendaSofia', N'Padilla Amaya', N'Administrador', N'miguel')
INSERT [dbo].[Usuarios] ([ID], [Usuario], [Nombres], [Apellidos], [Cargo], [Contraseña]) VALUES (48, N'RubenMoya', N'Ruben', N'Garza Moya', N'Jefe', N'ruben1234')
INSERT [dbo].[Usuarios] ([ID], [Usuario], [Nombres], [Apellidos], [Cargo], [Contraseña]) VALUES (49, N'RubenMoya', N'Ruben', N'Garza Moya', N'Jefe', N'ruben1234')
INSERT [dbo].[Usuarios] ([ID], [Usuario], [Nombres], [Apellidos], [Cargo], [Contraseña]) VALUES (50, N'RubenMoya', N'Ruben', N'Garza Moya', N'Jefe', N'ruben1234')
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
/****** Object:  Table [dbo].[Productos]    Script Date: 11/09/2018 12:18:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [int] NULL,
	[Nombre] [nvarchar](100) NULL,
	[Precio] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Productos] ON
INSERT [dbo].[Productos] ([Id], [Codigo], [Nombre], [Precio]) VALUES (1, 111, N'Gordita', 8)
INSERT [dbo].[Productos] ([Id], [Codigo], [Nombre], [Precio]) VALUES (2, 222, N'Refresco vidrio', 15)
INSERT [dbo].[Productos] ([Id], [Codigo], [Nombre], [Precio]) VALUES (10, 333, N'Agua Litro', 20)
INSERT [dbo].[Productos] ([Id], [Codigo], [Nombre], [Precio]) VALUES (11, 444, N'Agua Medio Litro', 15)
INSERT [dbo].[Productos] ([Id], [Codigo], [Nombre], [Precio]) VALUES (12, 555, N'Huevo Cocido', 5)
INSERT [dbo].[Productos] ([Id], [Codigo], [Nombre], [Precio]) VALUES (13, 666, N'Refresco Desechable', 15)
INSERT [dbo].[Productos] ([Id], [Codigo], [Nombre], [Precio]) VALUES (14, 777, N'Cafe', 15)
SET IDENTITY_INSERT [dbo].[Productos] OFF
/****** Object:  Table [dbo].[PAGOS]    Script Date: 11/09/2018 12:18:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PAGOS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](500) NULL,
	[Cantidad] [int] NULL,
	[Fecha] [nvarchar](60) NULL,
 CONSTRAINT [PK__PAGOS__3214EC270CBAE877] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[PAGOS] ON
INSERT [dbo].[PAGOS] ([ID], [Descripcion], [Cantidad], [Fecha]) VALUES (1, N'Chicharron', 1500, NULL)
INSERT [dbo].[PAGOS] ([ID], [Descripcion], [Cantidad], [Fecha]) VALUES (2, N'Pago de pollo', 400, NULL)
INSERT [dbo].[PAGOS] ([ID], [Descripcion], [Cantidad], [Fecha]) VALUES (3, N'Pago de leche', 400, NULL)
INSERT [dbo].[PAGOS] ([ID], [Descripcion], [Cantidad], [Fecha]) VALUES (4, N'Pago de chiles', 500, NULL)
INSERT [dbo].[PAGOS] ([ID], [Descripcion], [Cantidad], [Fecha]) VALUES (7, N'masa', 1200, N'jueves, 25 de octubre de 2018')
INSERT [dbo].[PAGOS] ([ID], [Descripcion], [Cantidad], [Fecha]) VALUES (8, N'pago queso', 200, NULL)
INSERT [dbo].[PAGOS] ([ID], [Descripcion], [Cantidad], [Fecha]) VALUES (9, N'queso', 150, N'jueves, 25 de octubre de 2018')
INSERT [dbo].[PAGOS] ([ID], [Descripcion], [Cantidad], [Fecha]) VALUES (10, N'sdgvweg', 234, N'25/10/2018')
INSERT [dbo].[PAGOS] ([ID], [Descripcion], [Cantidad], [Fecha]) VALUES (11, N'masa', 900, N'25/10/2018')
INSERT [dbo].[PAGOS] ([ID], [Descripcion], [Cantidad], [Fecha]) VALUES (12, N'Masa', 1500, N'28/10/2018')
INSERT [dbo].[PAGOS] ([ID], [Descripcion], [Cantidad], [Fecha]) VALUES (13, N'masa', 500, N'29/10/2018')
INSERT [dbo].[PAGOS] ([ID], [Descripcion], [Cantidad], [Fecha]) VALUES (14, N'chicharron', 1500, N'29/10/2018')
INSERT [dbo].[PAGOS] ([ID], [Descripcion], [Cantidad], [Fecha]) VALUES (15, N'Cocas', 50, N'30/10/2018')
INSERT [dbo].[PAGOS] ([ID], [Descripcion], [Cantidad], [Fecha]) VALUES (16, N'quesos', 220, N'30/10/2018')
INSERT [dbo].[PAGOS] ([ID], [Descripcion], [Cantidad], [Fecha]) VALUES (18, N'queso', 200, N'31/10/2018')
INSERT [dbo].[PAGOS] ([ID], [Descripcion], [Cantidad], [Fecha]) VALUES (20, N'queso', 200, N'05/11/2018')
SET IDENTITY_INSERT [dbo].[PAGOS] OFF
/****** Object:  Table [dbo].[CortedeCaja]    Script Date: 11/09/2018 12:18:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CortedeCaja](
	[Fecha] [varchar](50) NOT NULL,
	[NumVentas] [int] NULL,
	[TotalVentas] [int] NULL,
	[NumEgresos] [int] NULL,
	[TotalEgresos] [int] NULL,
	[Ganancia] [int] NULL,
 CONSTRAINT [PK_CortedeCaja] PRIMARY KEY CLUSTERED 
(
	[Fecha] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CortedeCaja] ([Fecha], [NumVentas], [TotalVentas], [NumEgresos], [TotalEgresos], [Ganancia]) VALUES (N'29/10/2018', 4, 4120, 1, 500, 3620)
INSERT [dbo].[CortedeCaja] ([Fecha], [NumVentas], [TotalVentas], [NumEgresos], [TotalEgresos], [Ganancia]) VALUES (N'30/10/2018', 2, 131, 2, 270, -139)
INSERT [dbo].[CortedeCaja] ([Fecha], [NumVentas], [TotalVentas], [NumEgresos], [TotalEgresos], [Ganancia]) VALUES (N'31/10/2018', 3, 925, 1, 200, 725)
/****** Object:  StoredProcedure [dbo].[AgregarUsuario]    Script Date: 11/09/2018 12:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AgregarUsuario]
@Usuario nvarchar(50),
@Nombres nvarchar(100),
@Apellidos nvarchar(100),
@Cargo nvarchar(50),
@Contraseña nvarchar(50)
as
insert into Usuarios values (@Usuario,@Nombres,@Apellidos,@Cargo,@Contraseña)
GO
/****** Object:  StoredProcedure [dbo].[Nuevopago]    Script Date: 11/09/2018 12:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Nuevopago]
@Descripcion nvarchar(500),
@Cantidad int,
@Fecha nvarchar(60)
as
insert into PAGOS values(@Descripcion,@Cantidad,@Fecha);
GO
/****** Object:  StoredProcedure [dbo].[MostrarVentas]    Script Date: 11/09/2018 12:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MostrarVentas]
as
select * from PAGOS where Fecha= CONVERT(VARCHAR(10), GETDATE(), 103)
GO
/****** Object:  StoredProcedure [dbo].[MostrarUsuarios]    Script Date: 11/09/2018 12:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[MostrarUsuarios]
as
select ID,Usuario,Nombres,Apellidos,Cargo from Usuarios
GO
/****** Object:  StoredProcedure [dbo].[MostrarProd]    Script Date: 11/09/2018 12:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[MostrarProd]
as
select * from Productos
GO
/****** Object:  StoredProcedure [dbo].[MostrarPagos]    Script Date: 11/09/2018 12:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[MostrarPagos]
as
select * from PAGOS where Fecha= CONVERT(VARCHAR(10), GETDATE(), 103)
GO
/****** Object:  StoredProcedure [dbo].[InsertarProd]    Script Date: 11/09/2018 12:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InsertarProd]
@Codigo int,
@Nombre nvarchar(50),
@Precio int
as
insert into Productos values(@Codigo,@Nombre,@Precio);
GO
/****** Object:  StoredProcedure [dbo].[Iniciarsesion]    Script Date: 11/09/2018 12:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Iniciarsesion]
    @Usuario nvarchar(50), 
    @Password nvarchar(50) 
    AS 
    SELECT * FROM Usuarios
    where Usuario=@Usuario and Contraseña=@Password
    insert into Usuarios values ('RubenMoya','Ruben','Garza Moya','Jefe','ruben1234')
GO
/****** Object:  StoredProcedure [dbo].[EliminarUsuario]    Script Date: 11/09/2018 12:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EliminarUsuario]
@ID int
as delete from Usuarios where ID=@ID;
GO
/****** Object:  StoredProcedure [dbo].[EliminarProducto]    Script Date: 11/09/2018 12:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EliminarProducto]
@ID int
as
delete from Productos where Id=@ID
GO
/****** Object:  StoredProcedure [dbo].[EliminarPago]    Script Date: 11/09/2018 12:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EliminarPago]
@ID int
as
delete from PAGOS where ID=@ID
GO
/****** Object:  StoredProcedure [dbo].[EditarProductos2]    Script Date: 11/09/2018 12:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EditarProductos2]
@Codigo int,
@Nombre nvarchar (100),
@Precio int,
@ID int
as
update Productos set Codigo=@Codigo, Nombre=@Nombre, Precio=@Precio where Id=@ID
GO
/****** Object:  StoredProcedure [dbo].[EditarProductos]    Script Date: 11/09/2018 12:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EditarProductos]
@Codigo int,
@Nombre nvarchar (100),
@Precio int,
@ID int
as
update Productos set Codigo=@Codigo, Nombre=@Nombre, Precio=@Precio where ID=@ID
GO
/****** Object:  StoredProcedure [dbo].[EditarPago]    Script Date: 11/09/2018 12:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[EditarPago]
@Descripcion nvarchar(500),
@Cantidad int,
@ID int,
@Fecha nvarchar(60)
as
update PAGOS set Descripcion=@Descripcion,Cantidad=@Cantidad
where ID=@ID
GO
