USE [master]
GO
/****** Object:  Database [Configuracao]    Script Date: 15/03/2023 12:21:57 ******/
CREATE DATABASE [Configuracao]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Configuracao', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Configuracao.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Configuracao_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Configuracao_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Configuracao] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Configuracao].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Configuracao] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Configuracao] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Configuracao] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Configuracao] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Configuracao] SET ARITHABORT OFF 
GO
ALTER DATABASE [Configuracao] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Configuracao] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Configuracao] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Configuracao] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Configuracao] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Configuracao] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Configuracao] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Configuracao] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Configuracao] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Configuracao] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Configuracao] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Configuracao] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Configuracao] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Configuracao] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Configuracao] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Configuracao] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Configuracao] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Configuracao] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Configuracao] SET  MULTI_USER 
GO
ALTER DATABASE [Configuracao] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Configuracao] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Configuracao] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Configuracao] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Configuracao] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Configuracao] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Configuracao] SET QUERY_STORE = OFF
GO
USE [Configuracao]
GO
/****** Object:  Table [dbo].[GrupoUsuario]    Script Date: 15/03/2023 12:21:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GrupoUsuario](
	[IdGrupo] [int] NOT NULL,
	[NomeGrupo] [varchar](50) NULL,
 CONSTRAINT [PK_GrupoUsuario] PRIMARY KEY CLUSTERED 
(
	[IdGrupo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GrupoUsuario _Permissao]    Script Date: 15/03/2023 12:21:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GrupoUsuario _Permissao](
	[CodPermissao] [int] NOT NULL,
	[CodGrupoUsuario] [int] NOT NULL,
 CONSTRAINT [PK_GrupoUsuario _Permissao] PRIMARY KEY CLUSTERED 
(
	[CodPermissao] ASC,
	[CodGrupoUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permissao]    Script Date: 15/03/2023 12:21:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permissao](
	[IdPermissao] [int] NOT NULL,
	[Descricao] [varchar](150) NULL,
 CONSTRAINT [PK_Permissao] PRIMARY KEY CLUSTERED 
(
	[IdPermissao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 15/03/2023 12:21:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[NomeUsuario] [varchar](60) NULL,
	[CPF] [varchar](14) NULL,
	[Email] [varchar](100) NULL,
	[Senha] [varchar](50) NULL,
	[Ativo] [bit] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario_GpUsuario]    Script Date: 15/03/2023 12:21:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario_GpUsuario](
	[CodUsuario] [int] NOT NULL,
	[CodGrupoUsuario] [int] NOT NULL,
 CONSTRAINT [PK_Usuario_GpUsuario] PRIMARY KEY CLUSTERED 
(
	[CodUsuario] ASC,
	[CodGrupoUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[GrupoUsuario _Permissao]  WITH CHECK ADD  CONSTRAINT [FK_GrupoUsuario _Permissao_GrupoUsuario] FOREIGN KEY([CodGrupoUsuario])
REFERENCES [dbo].[GrupoUsuario] ([IdGrupo])
GO
ALTER TABLE [dbo].[GrupoUsuario _Permissao] CHECK CONSTRAINT [FK_GrupoUsuario _Permissao_GrupoUsuario]
GO
ALTER TABLE [dbo].[GrupoUsuario _Permissao]  WITH CHECK ADD  CONSTRAINT [FK_GrupoUsuario _Permissao_Permissao] FOREIGN KEY([CodPermissao])
REFERENCES [dbo].[Permissao] ([IdPermissao])
GO
ALTER TABLE [dbo].[GrupoUsuario _Permissao] CHECK CONSTRAINT [FK_GrupoUsuario _Permissao_Permissao]
GO
ALTER TABLE [dbo].[Usuario_GpUsuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_GpUsuario_GrupoUsuario] FOREIGN KEY([CodGrupoUsuario])
REFERENCES [dbo].[GrupoUsuario] ([IdGrupo])
GO
ALTER TABLE [dbo].[Usuario_GpUsuario] CHECK CONSTRAINT [FK_Usuario_GpUsuario_GrupoUsuario]
GO
ALTER TABLE [dbo].[Usuario_GpUsuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_GpUsuario_Usuario] FOREIGN KEY([CodUsuario])
REFERENCES [dbo].[Usuario] ([Id])
GO
ALTER TABLE [dbo].[Usuario_GpUsuario] CHECK CONSTRAINT [FK_Usuario_GpUsuario_Usuario]
GO
USE [master]
GO
ALTER DATABASE [Configuracao] SET  READ_WRITE 
GO
