BEGIN TRANSACTION;
CREATE TABLE [TB_ESTADIO] (
    [Id] int NOT NULL IDENTITY,
    [Nome] varchar(200) NULL,
    [Cidade] varchar(200) NULL,
    [Capacidade] int NOT NULL,
    CONSTRAINT [PK_TB_ESTADIO] PRIMARY KEY ([Id])
);

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Capacidade', N'Cidade', N'Nome') AND [object_id] = OBJECT_ID(N'[TB_ESTADIO]'))
    SET IDENTITY_INSERT [TB_ESTADIO] ON;
INSERT INTO [TB_ESTADIO] ([Id], [Capacidade], [Cidade], [Nome])
VALUES (1, 43713, 'SP', 'Allianz Park'),
(2, 49267, 'SP', 'Neo Química Arena'),
(3, 66795, 'SP', 'Morumbi'),
(4, 78838, 'RJ', 'Maracanã'),
(5, 44200, 'MS', 'Morenão'),
(6, 32050, 'RN', 'Arena das Dunas'),
(7, 27000, 'DF', 'Boca de Jacaré');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Capacidade', N'Cidade', N'Nome') AND [object_id] = OBJECT_ID(N'[TB_ESTADIO]'))
    SET IDENTITY_INSERT [TB_ESTADIO] OFF;

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20260406112436_MigracaoEstadios', N'10.0.5');

COMMIT;
GO

