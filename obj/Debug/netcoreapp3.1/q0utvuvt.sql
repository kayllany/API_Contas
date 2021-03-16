IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Conta] (
    [Id] int NOT NULL IDENTITY,
    [Valor] decimal(18,2) NOT NULL,
    [DataVencimento] datetime2 NOT NULL,
    [NomeCredor] nvarchar(max) NULL,
    [DataPagamento] datetime2 NULL,
    CONSTRAINT [PK_Conta] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210217161421_InitialCreate', N'3.1.11');

GO

