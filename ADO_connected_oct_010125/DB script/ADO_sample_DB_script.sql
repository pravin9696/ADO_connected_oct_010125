USE [master]
GO
/****** Object:  Database [DB_ADO_connected_sample]    Script Date: 1.1.25 17:26:59 ******/
CREATE DATABASE [DB_ADO_connected_sample]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DB_ADO_connected_sample', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\DB_ADO_connected_sample.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DB_ADO_connected_sample_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\DB_ADO_connected_sample_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [DB_ADO_connected_sample] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_ADO_connected_sample].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB_ADO_connected_sample] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DB_ADO_connected_sample] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DB_ADO_connected_sample] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DB_ADO_connected_sample] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DB_ADO_connected_sample] SET ARITHABORT OFF 
GO
ALTER DATABASE [DB_ADO_connected_sample] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DB_ADO_connected_sample] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DB_ADO_connected_sample] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DB_ADO_connected_sample] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DB_ADO_connected_sample] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DB_ADO_connected_sample] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DB_ADO_connected_sample] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DB_ADO_connected_sample] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DB_ADO_connected_sample] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DB_ADO_connected_sample] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DB_ADO_connected_sample] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DB_ADO_connected_sample] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DB_ADO_connected_sample] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DB_ADO_connected_sample] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DB_ADO_connected_sample] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DB_ADO_connected_sample] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DB_ADO_connected_sample] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DB_ADO_connected_sample] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DB_ADO_connected_sample] SET  MULTI_USER 
GO
ALTER DATABASE [DB_ADO_connected_sample] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DB_ADO_connected_sample] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DB_ADO_connected_sample] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DB_ADO_connected_sample] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DB_ADO_connected_sample] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DB_ADO_connected_sample] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DB_ADO_connected_sample] SET QUERY_STORE = ON
GO
ALTER DATABASE [DB_ADO_connected_sample] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [DB_ADO_connected_sample]
GO
/****** Object:  Table [dbo].[tblEmployee]    Script Date: 1.1.25 17:26:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblEmployee](
	[empid] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[contact] [bigint] NULL,
 CONSTRAINT [PK_tblEmployee] PRIMARY KEY CLUSTERED 
(
	[empid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblEmployee] ON 

INSERT [dbo].[tblEmployee] ([empid], [name], [Address], [contact]) VALUES (1, N'dinesh', N'mumbai', 8888)
INSERT [dbo].[tblEmployee] ([empid], [name], [Address], [contact]) VALUES (2, N'rajesh', N'pune', 77)
INSERT [dbo].[tblEmployee] ([empid], [name], [Address], [contact]) VALUES (3, N'pankaj', N'kolhapur', 55555)
INSERT [dbo].[tblEmployee] ([empid], [name], [Address], [contact]) VALUES (4, N'vijay', N'nagar', 5674568796)
INSERT [dbo].[tblEmployee] ([empid], [name], [Address], [contact]) VALUES (5, N'anand', N'nashik', 67543489768)
SET IDENTITY_INSERT [dbo].[tblEmployee] OFF
GO
USE [master]
GO
ALTER DATABASE [DB_ADO_connected_sample] SET  READ_WRITE 
GO
