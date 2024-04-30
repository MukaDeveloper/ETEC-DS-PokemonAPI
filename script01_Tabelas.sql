IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [TB_TREINADORES] (
    [Id] int NOT NULL IDENTITY,
    [Nome] varchar(100) NOT NULL,
    [Insignias] nvarchar(max) NOT NULL,
    [Regiao] varchar(100) NOT NULL,
    CONSTRAINT [PK_TB_TREINADORES] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [TB_POKEMONS] (
    [Id] int NOT NULL IDENTITY,
    [Nome] varchar(100) NOT NULL,
    [Altura] float NOT NULL,
    [Peso] float NOT NULL,
    [Genero] varchar(100) NOT NULL,
    [Tipo] nvarchar(max) NOT NULL,
    [Nivel] int NOT NULL,
    [Vida] int NOT NULL,
    [Ataque] int NOT NULL,
    [Defesa] int NOT NULL,
    [Velocidade] int NOT NULL,
    [TreinadorId] int NULL,
    CONSTRAINT [PK_TB_POKEMONS] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_TB_POKEMONS_TB_TREINADORES_TreinadorId] FOREIGN KEY ([TreinadorId]) REFERENCES [TB_TREINADORES] ([Id])
);
GO

CREATE TABLE [TB_HABILIDADES] (
    [Id] int NOT NULL IDENTITY,
    [Nome] varchar(100) NOT NULL,
    [Descricao] varchar(100) NOT NULL,
    [Poder] int NOT NULL,
    [Precisao] int NOT NULL,
    [PP] int NOT NULL,
    [PokemonId] int NULL,
    CONSTRAINT [PK_TB_HABILIDADES] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_TB_HABILIDADES_TB_POKEMONS_PokemonId] FOREIGN KEY ([PokemonId]) REFERENCES [TB_POKEMONS] ([Id])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Descricao', N'Nome', N'PP', N'Poder', N'PokemonId', N'Precisao') AND [object_id] = OBJECT_ID(N'[TB_HABILIDADES]'))
    SET IDENTITY_INSERT [TB_HABILIDADES] ON;
INSERT INTO [TB_HABILIDADES] ([Id], [Descricao], [Nome], [PP], [Poder], [PokemonId], [Precisao])
VALUES (1, 'Um ataque corporal comum.', 'Tackle', 35, 40, NULL, 100),
(2, 'Reduz o Ataque do oponente.', 'Growl', 40, 0, NULL, 100),
(3, 'Ataca com vinhas ou chicotes.', 'Vine Whip', 25, 45, NULL, 100),
(4, 'Lâminas de folha são lançadas como navalhas.', 'Razor Leaf', 25, 55, NULL, 95),
(5, 'Ataque com uma rajada de fogo intenso.', 'Flamethrower', 15, 90, NULL, 100),
(6, 'Envolve o oponente em chamas por 2 a 5 turnos.', 'Fire Spin', 15, 35, NULL, 85),
(7, 'Um ataque cortante com alta chance de acerto crítico.', 'Slash', 20, 70, NULL, 100);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Descricao', N'Nome', N'PP', N'Poder', N'PokemonId', N'Precisao') AND [object_id] = OBJECT_ID(N'[TB_HABILIDADES]'))
    SET IDENTITY_INSERT [TB_HABILIDADES] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Altura', N'Ataque', N'Defesa', N'Genero', N'Nivel', N'Nome', N'Peso', N'Tipo', N'TreinadorId', N'Velocidade', N'Vida') AND [object_id] = OBJECT_ID(N'[TB_POKEMONS]'))
    SET IDENTITY_INSERT [TB_POKEMONS] ON;
INSERT INTO [TB_POKEMONS] ([Id], [Altura], [Ataque], [Defesa], [Genero], [Nivel], [Nome], [Peso], [Tipo], [TreinadorId], [Velocidade], [Vida])
VALUES (1, 0.69999999999999996E0, 49, 49, 'M', 1, 'Bulbasaur', 6.9000000000000004E0, N'[9,13]', NULL, 45, 45),
(2, 1.0E0, 62, 63, 'M', 1, 'Ivysaur', 13.0E0, N'[9,13]', NULL, 60, 60),
(3, 2.0E0, 82, 83, 'M', 1, 'Venusaur', 100.0E0, N'[9,13]', NULL, 80, 80),
(4, 0.59999999999999998E0, 52, 43, 'M', 1, 'Charmander', 8.5E0, N'[6]', NULL, 65, 39),
(5, 1.1000000000000001E0, 64, 58, 'M', 1, 'Charmeleon', 19.0E0, N'[6]', NULL, 80, 58),
(6, 1.7E0, 84, 78, 'M', 1, 'Charizard', 90.5E0, N'[6,7]', NULL, 100, 78);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Altura', N'Ataque', N'Defesa', N'Genero', N'Nivel', N'Nome', N'Peso', N'Tipo', N'TreinadorId', N'Velocidade', N'Vida') AND [object_id] = OBJECT_ID(N'[TB_POKEMONS]'))
    SET IDENTITY_INSERT [TB_POKEMONS] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Insignias', N'Nome', N'Regiao') AND [object_id] = OBJECT_ID(N'[TB_TREINADORES]'))
    SET IDENTITY_INSERT [TB_TREINADORES] ON;
INSERT INTO [TB_TREINADORES] ([Id], [Insignias], [Nome], [Regiao])
VALUES (1, N'[0]', 'Brock', 'Kanto'),
(2, N'[1]', 'Misty', 'Kanto'),
(3, N'[2]', 'Sg. Surge', 'Kanto'),
(4, N'[3]', 'Erika', 'Kanto'),
(5, N'[4]', 'Koga', 'Kanto'),
(6, N'[5]', 'Sabrina', 'Kanto'),
(7, N'[6]', 'Blaine', 'Kanto'),
(8, N'[7]', 'Giovanni', 'Kanto');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Insignias', N'Nome', N'Regiao') AND [object_id] = OBJECT_ID(N'[TB_TREINADORES]'))
    SET IDENTITY_INSERT [TB_TREINADORES] OFF;
GO

CREATE INDEX [IX_TB_HABILIDADES_PokemonId] ON [TB_HABILIDADES] ([PokemonId]);
GO

CREATE INDEX [IX_TB_POKEMONS_TreinadorId] ON [TB_POKEMONS] ([TreinadorId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240430224348_InitialCreate', N'8.0.4');
GO

COMMIT;
GO

