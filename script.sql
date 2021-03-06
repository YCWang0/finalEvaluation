USE [master]
GO
/****** Object:  Database [YichenWang.ClientInformationSystem]    Script Date: 8/6/2020 3:44:03 PM ******/
CREATE DATABASE [YichenWang.ClientInformationSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'YichenWang.ClientInformationSystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQL2020\MSSQL\DATA\YichenWang.ClientInformationSystem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'YichenWang.ClientInformationSystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQL2020\MSSQL\DATA\YichenWang.ClientInformationSystem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [YichenWang.ClientInformationSystem] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [YichenWang.ClientInformationSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [YichenWang.ClientInformationSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [YichenWang.ClientInformationSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [YichenWang.ClientInformationSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [YichenWang.ClientInformationSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [YichenWang.ClientInformationSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [YichenWang.ClientInformationSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [YichenWang.ClientInformationSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [YichenWang.ClientInformationSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [YichenWang.ClientInformationSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [YichenWang.ClientInformationSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [YichenWang.ClientInformationSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [YichenWang.ClientInformationSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [YichenWang.ClientInformationSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [YichenWang.ClientInformationSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [YichenWang.ClientInformationSystem] SET  ENABLE_BROKER 
GO
ALTER DATABASE [YichenWang.ClientInformationSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [YichenWang.ClientInformationSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [YichenWang.ClientInformationSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [YichenWang.ClientInformationSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [YichenWang.ClientInformationSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [YichenWang.ClientInformationSystem] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [YichenWang.ClientInformationSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [YichenWang.ClientInformationSystem] SET RECOVERY FULL 
GO
ALTER DATABASE [YichenWang.ClientInformationSystem] SET  MULTI_USER 
GO
ALTER DATABASE [YichenWang.ClientInformationSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [YichenWang.ClientInformationSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [YichenWang.ClientInformationSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [YichenWang.ClientInformationSystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [YichenWang.ClientInformationSystem] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'YichenWang.ClientInformationSystem', N'ON'
GO
ALTER DATABASE [YichenWang.ClientInformationSystem] SET QUERY_STORE = OFF
GO
USE [YichenWang.ClientInformationSystem]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 8/6/2020 3:44:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 8/6/2020 3:44:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Phones] [nvarchar](30) NOT NULL,
	[Address] [nvarchar](100) NOT NULL,
	[AddedOn] [datetime2](7) NOT NULL,
	[InteractionsId] [int] NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 8/6/2020 3:44:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](10) NOT NULL,
	[Designation] [nvarchar](50) NOT NULL,
	[InteractionsId] [int] NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Interactions]    Script Date: 8/6/2020 3:44:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Interactions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[EmpId] [int] NOT NULL,
	[IntType] [nvarchar](1) NOT NULL,
	[IntDate] [datetime2](7) NOT NULL,
	[Remarks] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_Interactions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [IX_Clients_InteractionsId]    Script Date: 8/6/2020 3:44:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_Clients_InteractionsId] ON [dbo].[Clients]
(
	[InteractionsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Employees_InteractionsId]    Script Date: 8/6/2020 3:44:03 PM ******/
CREATE NONCLUSTERED INDEX [IX_Employees_InteractionsId] ON [dbo].[Employees]
(
	[InteractionsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Clients]  WITH CHECK ADD  CONSTRAINT [FK_Clients_Interactions_InteractionsId] FOREIGN KEY([InteractionsId])
REFERENCES [dbo].[Interactions] ([Id])
GO
ALTER TABLE [dbo].[Clients] CHECK CONSTRAINT [FK_Clients_Interactions_InteractionsId]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Interactions_InteractionsId] FOREIGN KEY([InteractionsId])
REFERENCES [dbo].[Interactions] ([Id])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Interactions_InteractionsId]
GO
USE [master]
GO
ALTER DATABASE [YichenWang.ClientInformationSystem] SET  READ_WRITE 
GO
