# Api Exemplo
 
+ Add MSQL DataBase 

CREATE DATABASE EmployeeDB
GO

USE [EmployeeDB]

CREATE TABLE [dbo].[Employee](
	[EmployeeId] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeName] [varchar](500) NULL,
	[Department] [varchar](500) NULL,
	[DateOfJoining] [date] NULL,
	[PhotoFileName] [varchar](500) NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Department](
	[DepartmentId] [int] IDENTITY(1,1) NOT NULL,
	[DepartmentName] [varchar](500) NULL
) ON [PRIMARY]
GO

  "ConnectionStrings": {
    "EmployeeAppCon": "Server=.\\SQLEXPRESS;Initial Catalog=EmployeeDB;Trusted_Connection=True;MultipleActiveResultSets=true"
  },

+ Enable CORS
+ JSON Serializer

+ add verbs
- POST
- GET
- PULL
- DELETE
- GETALL