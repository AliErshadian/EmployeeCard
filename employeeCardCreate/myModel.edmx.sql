
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/30/2020 11:18:13
-- Generated from EDMX file: E:\Projects\employeeCard\employeeCardCreate\myModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [EmployeeCard];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CompanyProperty]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CompanyProperty];
GO
IF OBJECT_ID(N'[dbo].[ContractorProperty]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ContractorProperty];
GO
IF OBJECT_ID(N'[dbo].[Employees]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employees];
GO
IF OBJECT_ID(N'[dbo].[users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[users];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CompanyProperties'
CREATE TABLE [dbo].[CompanyProperties] (
    [ID] bigint  NOT NULL,
    [CompanyName] nvarchar(max)  NOT NULL,
    [RepresendativeName] nvarchar(max)  NOT NULL,
    [PhoneNumber] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'ContractorProperties'
CREATE TABLE [dbo].[ContractorProperties] (
    [ID] bigint  NOT NULL,
    [ContractorName] nvarchar(max)  NOT NULL,
    [RepresendativeName] nvarchar(max)  NOT NULL,
    [PhoneNumber] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Employees'
CREATE TABLE [dbo].[Employees] (
    [ID] bigint  NOT NULL,
    [FirstName] nvarchar(50)  NOT NULL,
    [LastName] nvarchar(50)  NOT NULL,
    [FatherName] nvarchar(50)  NULL,
    [BirthDate] datetime  NOT NULL,
    [BirthPlace] nvarchar(50)  NOT NULL,
    [NationalId] nvarchar(50)  NULL,
    [NationalCode] nvarchar(50)  NULL,
    [PassportId] nvarchar(50)  NULL,
    [Region] nvarchar(50)  NOT NULL,
    [JobSituation] nvarchar(50)  NOT NULL,
    [LetterId] nvarchar(50)  NOT NULL,
    [AnalArea] nvarchar(50)  NOT NULL,
    [FirstArea] varchar(max)  NULL,
    [SecondArea] varchar(max)  NULL,
    [CreateDate] datetime  NOT NULL,
    [ExpireDate] datetime  NOT NULL,
    [SecondaryCard] int  NULL,
    [DateSecondaryCard] datetime  NULL,
    [LostCard] nchar(10)  NULL,
    [TypeLostCard] nvarchar(50)  NULL,
    [FindLostCardDate] datetime  NULL,
    [Image] varbinary(max)  NOT NULL,
    [CompanyName] nvarchar(max)  NOT NULL,
    [CompanyResName] nvarchar(max)  NOT NULL,
    [CompanyNum] nvarchar(max)  NOT NULL,
    [ContractorName] nvarchar(max)  NOT NULL,
    [ContractorResName] nvarchar(max)  NOT NULL,
    [ContarctorNum] nvarchar(max)  NOT NULL,
    [Print] int  NULL,
    [PrintDate] datetime  NULL,
    [is] int  NULL,
    [LostCardDate] datetime  NULL,
    [user] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'users'
CREATE TABLE [dbo].[users] (
    [username] nvarchar(50)  NOT NULL,
    [password] nvarchar(50)  NOT NULL,
    [access] nchar(10)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'CompanyProperties'
ALTER TABLE [dbo].[CompanyProperties]
ADD CONSTRAINT [PK_CompanyProperties]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'ContractorProperties'
ALTER TABLE [dbo].[ContractorProperties]
ADD CONSTRAINT [PK_ContractorProperties]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [PK_Employees]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [username] in table 'users'
ALTER TABLE [dbo].[users]
ADD CONSTRAINT [PK_users]
    PRIMARY KEY CLUSTERED ([username] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------