
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/04/2021 09:52:38
-- Generated from EDMX file: C:\Users\Datanet\Desktop\WebApplicationApi\WebApplicationApi\Models\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Database1];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Accessi]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Accessi];
GO
IF OBJECT_ID(N'[dbo].[Persone]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Persone];
GO
IF OBJECT_ID(N'[dbo].[Preferiti]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Preferiti];
GO
IF OBJECT_ID(N'[dbo].[Prodotti]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Prodotti];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Accessi'
CREATE TABLE [dbo].[Accessi] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [datatime] datetime  NOT NULL,
    [id_utente] int  NOT NULL,
    [PersoneId] int  NOT NULL
);
GO

-- Creating table 'Persone'
CREATE TABLE [dbo].[Persone] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(50)  NOT NULL,
    [surname] nvarchar(50)  NOT NULL,
    [email] nvarchar(50)  NOT NULL,
    [password] nvarchar(50)  NOT NULL,
    [city] nvarchar(50)  NOT NULL,
    [address] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Preferiti'
CREATE TABLE [dbo].[Preferiti] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [id_prodotto] int  NOT NULL,
    [id_utente] int  NOT NULL,
    [PersoneId] int  NOT NULL
);
GO

-- Creating table 'Prodotti'
CREATE TABLE [dbo].[Prodotti] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nome_prodotto] nvarchar(50)  NOT NULL,
    [prezzo] float  NOT NULL,
    [PersoneId] int  NOT NULL,
    [Preferiti_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Accessi'
ALTER TABLE [dbo].[Accessi]
ADD CONSTRAINT [PK_Accessi]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Persone'
ALTER TABLE [dbo].[Persone]
ADD CONSTRAINT [PK_Persone]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Preferiti'
ALTER TABLE [dbo].[Preferiti]
ADD CONSTRAINT [PK_Preferiti]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Prodotti'
ALTER TABLE [dbo].[Prodotti]
ADD CONSTRAINT [PK_Prodotti]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PersoneId] in table 'Accessi'
ALTER TABLE [dbo].[Accessi]
ADD CONSTRAINT [FK_PersoneAccessi]
    FOREIGN KEY ([PersoneId])
    REFERENCES [dbo].[Persone]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersoneAccessi'
CREATE INDEX [IX_FK_PersoneAccessi]
ON [dbo].[Accessi]
    ([PersoneId]);
GO

-- Creating foreign key on [PersoneId] in table 'Preferiti'
ALTER TABLE [dbo].[Preferiti]
ADD CONSTRAINT [FK_PersonePreferiti]
    FOREIGN KEY ([PersoneId])
    REFERENCES [dbo].[Persone]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonePreferiti'
CREATE INDEX [IX_FK_PersonePreferiti]
ON [dbo].[Preferiti]
    ([PersoneId]);
GO

-- Creating foreign key on [PersoneId] in table 'Prodotti'
ALTER TABLE [dbo].[Prodotti]
ADD CONSTRAINT [FK_PersoneProdotti]
    FOREIGN KEY ([PersoneId])
    REFERENCES [dbo].[Persone]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersoneProdotti'
CREATE INDEX [IX_FK_PersoneProdotti]
ON [dbo].[Prodotti]
    ([PersoneId]);
GO

-- Creating foreign key on [Preferiti_Id] in table 'Prodotti'
ALTER TABLE [dbo].[Prodotti]
ADD CONSTRAINT [FK_ProdottiPreferiti]
    FOREIGN KEY ([Preferiti_Id])
    REFERENCES [dbo].[Preferiti]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProdottiPreferiti'
CREATE INDEX [IX_FK_ProdottiPreferiti]
ON [dbo].[Prodotti]
    ([Preferiti_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------