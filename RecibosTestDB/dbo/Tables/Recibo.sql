CREATE TABLE [dbo].[Recibo] (
    [Id]          BIGINT          IDENTITY (1, 1) NOT NULL,
    [Monto]       DECIMAL (18, 2) NOT NULL,
    [Comentario]  VARCHAR (MAX)   NOT NULL,
    [Fecha]       DATE            NOT NULL,
    [MonedaId]    BIGINT          NOT NULL,
    [ProveedorId] BIGINT          NOT NULL,
    [Estado]      BIT             NOT NULL,
    [UserReg]     BIGINT          NOT NULL,
    [FechaReg]    DATETIME        NOT NULL,
    [UserMod]     BIGINT          NULL,
    [FechaMod]    DATETIME        NULL,
    CONSTRAINT [PK_Recibo] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Recibo_Moneda] FOREIGN KEY ([MonedaId]) REFERENCES [dbo].[Moneda] ([Id]),
    CONSTRAINT [FK_Recibo_Proveedor] FOREIGN KEY ([ProveedorId]) REFERENCES [dbo].[Proveedor] ([Id]),
    CONSTRAINT [FK_Recibo_Usuario] FOREIGN KEY ([UserReg]) REFERENCES [dbo].[Usuario] ([Id]),
    CONSTRAINT [FK_Recibo_Usuario1] FOREIGN KEY ([UserMod]) REFERENCES [dbo].[Usuario] ([Id])
);

