-- Migración: módulo de Ventas + Login (Administrador / Vendedor)
-- Ejecutar este script en SSMS conectado a la base CATALOGO_DB
-- (el mismo servidor .\SQLEXPRESS que ya usa la aplicación).

USE CATALOGO_DB
GO

-- 1) Agregar control de stock a ARTICULOS -----------------------------------
IF NOT EXISTS (
    SELECT 1 FROM sys.columns
    WHERE object_id = OBJECT_ID('ARTICULOS') AND name = 'Stock'
)
BEGIN
    ALTER TABLE ARTICULOS ADD Stock int NOT NULL DEFAULT 0
END
GO

-- Stock inicial para los artículos de ejemplo que ya existen
UPDATE ARTICULOS SET Stock = 15 WHERE Codigo = 'S01'
UPDATE ARTICULOS SET Stock = 20 WHERE Codigo = 'M03'
UPDATE ARTICULOS SET Stock = 10 WHERE Codigo = 'S99'
UPDATE ARTICULOS SET Stock = 8  WHERE Codigo = 'S56'
UPDATE ARTICULOS SET Stock = 12 WHERE Codigo = 'A23'
GO

-- 2) Tabla de USUARIOS (login) ------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM sys.tables WHERE name = 'USUARIOS')
BEGIN
    CREATE TABLE dbo.USUARIOS (
        Id            int IDENTITY(1,1) NOT NULL,
        NombreUsuario varchar(50)  NOT NULL,
        Contrasenia   varchar(100) NOT NULL,
        Nombre        varchar(100) NULL,
        Rol           varchar(20)  NOT NULL,
        CONSTRAINT PK_USUARIOS PRIMARY KEY CLUSTERED (Id ASC),
        CONSTRAINT UQ_USUARIOS_NombreUsuario UNIQUE (NombreUsuario)
    )
END
GO

-- Usuarios de ejemplo: uno administrador y uno vendedor.
-- IMPORTANTE: cambiá estas contraseñas antes de entregar el trabajo.
IF NOT EXISTS (SELECT 1 FROM USUARIOS WHERE NombreUsuario = 'admin')
    INSERT INTO USUARIOS (NombreUsuario, Contrasenia, Nombre, Rol)
    VALUES ('admin', 'admin123', 'Administrador', 'Administrador')

IF NOT EXISTS (SELECT 1 FROM USUARIOS WHERE NombreUsuario = 'vendedor1')
    INSERT INTO USUARIOS (NombreUsuario, Contrasenia, Nombre, Rol)
    VALUES ('vendedor1', 'vend123', 'Vendedor Uno', 'Vendedor')
GO

-- 3) Tabla de VENTAS (cabecera) ----------------------------------------------
IF NOT EXISTS (SELECT 1 FROM sys.tables WHERE name = 'VENTAS')
BEGIN
    CREATE TABLE dbo.VENTAS (
        Id        int IDENTITY(1,1) NOT NULL,
        Fecha     datetime NOT NULL,
        IdUsuario int NOT NULL,
        Total     money NOT NULL,
        CONSTRAINT PK_VENTAS PRIMARY KEY CLUSTERED (Id ASC),
        CONSTRAINT FK_VENTAS_USUARIOS FOREIGN KEY (IdUsuario) REFERENCES USUARIOS (Id)
    )
END
GO

-- 4) Tabla de DETALLE_VENTA (líneas de cada venta) ---------------------------
IF NOT EXISTS (SELECT 1 FROM sys.tables WHERE name = 'DETALLE_VENTA')
BEGIN
    CREATE TABLE dbo.DETALLE_VENTA (
        Id             int IDENTITY(1,1) NOT NULL,
        IdVenta        int NOT NULL,
        IdArticulo     int NOT NULL,
        Cantidad       int NOT NULL,
        PrecioUnitario money NOT NULL,
        CONSTRAINT PK_DETALLE_VENTA PRIMARY KEY CLUSTERED (Id ASC),
        CONSTRAINT FK_DETALLE_VENTA_VENTAS FOREIGN KEY (IdVenta) REFERENCES VENTAS (Id),
        CONSTRAINT FK_DETALLE_VENTA_ARTICULOS FOREIGN KEY (IdArticulo) REFERENCES ARTICULOS (Id)
    )
END
GO

-- Listo. Verificación rápida:
SELECT * FROM USUARIOS
SELECT Id, Codigo, Nombre, Precio, Stock FROM ARTICULOS
