CREATE TABLE [dbo].[Usuario] (
    [Id]       BIGINT        IDENTITY (1, 1) NOT NULL,
    [Nombre]   VARCHAR (MAX) NOT NULL,
    [Username] VARCHAR (MAX) NOT NULL,
    [Password] VARCHAR (MAX) NOT NULL,
    [RolId]    BIGINT        NOT NULL,
    [Estado]   BIT           NOT NULL,
    [FechaReg] DATETIME      NOT NULL,
    [FechaMod] DATETIME      NOT NULL,
    CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Usuario_Rol] FOREIGN KEY ([RolId]) REFERENCES [dbo].[Rol] ([Id])
);

