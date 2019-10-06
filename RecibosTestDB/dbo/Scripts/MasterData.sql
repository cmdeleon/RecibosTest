
INSERT INTO [dbo].[Rol] ([Nombre]) VALUES ('Admin')
INSERT INTO [dbo].[Rol] ([Nombre]) VALUES ('User')

INSERT INTO [dbo].[Usuario] ([Nombre], [Username], [Password], [RolId], [Estado], [FechaReg], [FechaMod]) VALUES ('Administrador', 'admin', '1234', 1, 1, GETDATE(), GETDATE())
INSERT INTO [dbo].[Usuario] ([Nombre], [Username], [Password], [RolId], [Estado], [FechaReg], [FechaMod]) VALUES ('Usuario', 'user', '1234', 1, 1, GETDATE(), GETDATE())

INSERT INTO [dbo].[Moneda] ([Nombre], [Estado], [UserReg], [FechaReg], [UserMod], [FechaMod]) VALUES ('Peso', 1, 1, GETDATE(), 1, GETDATE())
INSERT INTO [dbo].[Moneda] ([Nombre], [Estado], [UserReg], [FechaReg], [UserMod], [FechaMod]) VALUES ('Dolar', 1, 1, GETDATE(), 1, GETDATE())
INSERT INTO [dbo].[Moneda] ([Nombre], [Estado], [UserReg], [FechaReg], [UserMod], [FechaMod]) VALUES ('Euro', 1, 1, GETDATE(), 1, GETDATE())

INSERT INTO [dbo].[Proveedor] ([Nombre], [Estado], [UserReg], [FechaReg], [UserMod], [FechaMod]) VALUES ('Telmex', 1 ,1, GETDATE(), 1, GETDATE())
INSERT INTO [dbo].[Proveedor] ([Nombre], [Estado], [UserReg], [FechaReg], [UserMod], [FechaMod]) VALUES ('Cemex', 1 ,1, GETDATE(), 1, GETDATE())
INSERT INTO [dbo].[Proveedor] ([Nombre], [Estado], [UserReg], [FechaReg], [UserMod], [FechaMod]) VALUES ('Telcel', 1 ,1, GETDATE(), 1, GETDATE())
INSERT INTO [dbo].[Proveedor] ([Nombre], [Estado], [UserReg], [FechaReg], [UserMod], [FechaMod]) VALUES ('Ternium', 1 ,1, GETDATE(), 1, GETDATE())