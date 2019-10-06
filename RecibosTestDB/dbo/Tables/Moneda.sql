CREATE TABLE [dbo].[Moneda] (
    [Id]       BIGINT        IDENTITY (1, 1) NOT NULL,
    [Nombre]   VARCHAR (MAX) NOT NULL,
    [Estado]   BIT           NOT NULL,
    [UserReg]  BIGINT        NOT NULL,
    [FechaReg] DATETIME      NOT NULL,
    [UserMod]  BIGINT        NULL,
    [FechaMod] DATETIME      NULL,
    CONSTRAINT [PK_Moneda] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Moneda_Usuario] FOREIGN KEY ([UserReg]) REFERENCES [dbo].[Usuario] ([Id]),
    CONSTRAINT [FK_Moneda_Usuario1] FOREIGN KEY ([UserMod]) REFERENCES [dbo].[Usuario] ([Id])
);

