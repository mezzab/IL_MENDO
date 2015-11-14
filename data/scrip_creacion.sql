DROP TABLE BD.VIAJES
DROP TABLE BD.ESTADO_VIAJE
DROP TABLE BD.REMITOS
DROP TABLE BD.ADELANTOS
DROP TABLE BD.CHOFERES
DROP TABLE BD.CLIENTES
DROP TABLE BD.FILA_TARIFA	
DROP TABLE BD.TARIFAS
DROP TABLE BD.TRAMOS
DROP TABLE BD.CARGAS_GASOIL
DROP TABLE BD.ESTACIONES
DROP TABLE BD.CUBIERTAS
DROP TABLE BD.REPARACIONES
DROP TABLE BD.GASTOS
DROP TABLE BD.CAMIONES

DROP SCHEMA DB

				
--============================================================	
--				  SISTEMA DE TRANSPORTE
--                 PERSONALIZADO PARA
--					  IL MENDO SRL 				
-- ===========================================================

USE [IL_MENDO]
GO

--============================================================	
--		CREACION DEL ESQUEMA PARA IL MENDO
-- ===========================================================

--CREATE SCHEMA [BD] 
--GO


--============================================================
						--TABLA CAMIONES
--============================================================


CREATE TABLE BD.CAMIONES(
	CAMI_ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	CAMI_APODO VARCHAR(20) NOT NULL UNIQUE,
	CAMI_MARCA VARCHAR(16) NOT NULL,
	CAMI_MODELO VARCHAR(16) NOT NULL, 
	CAMI_AÑOS VARCHAR(10) NOT NULL,
	CAMI_LITROS_DISPONIBLES INT NOT NULL
	)



--============================================================
						--TABLA GASTOS
--============================================================


CREATE TABLE BD.GASTOS(
	GASTO_ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	GASTO_CAMION_ID INT NOT NULL FOREIGN KEY REFERENCES BD.CAMIONES(CAMI_ID),
	GASTO_TIPO VARCHAR(30) NOT NULL,
	GASTO_FECHA DATETIME NOT NULL,
	GASTO_COSTO_TOTAL MONEY NOT NULL,
	)

--============================================================
						--TABLA CUBIERTAS
--============================================================

CREATE TABLE BD.CUBIERTAS(
	CUBI_GASTO_ID INT NOT NULL FOREIGN KEY REFERENCES BD.GASTOS(GASTO_ID),
	CUBI_CANTIDAD INT NOT NULL
	)

--============================================================
						--TABLA REPARACIONES
--============================================================

CREATE TABLE BD.REPARACIONES(
	REPA_GASTO_ID INT NOT NULL FOREIGN KEY REFERENCES BD.GASTOS(GASTO_ID),
	REPA_DESCRIPCION VARCHAR(100)
)


--============================================================
						--TABLA ESTACIONES
--============================================================

CREATE TABLE BD.ESTACIONES(
	ESTA_ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	ESTA_DESCRIPCION VARCHAR(32),
	ESTA_DIRECCION VARCHAR(32)
	)


INSERT INTO [BD].[ESTACIONES]
           ([ESTA_DESCRIPCION], [ESTA_DIRECCION])
     VALUES
           ('Shell Areco', 'Ruta 41 a 800 mts. de Ruta 8')


--============================================================
						--TABLA CARGAS DE GASOIL
--============================================================

CREATE TABLE BD.CARGAS_GASOIL(
	CARG_ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	CARG_CAMION_ID INT NOT NULL FOREIGN KEY REFERENCES BD.CAMIONES(CAMI_ID),
	CARG_ESTACION_ID INT NOT NULL FOREIGN KEY REFERENCES BD.ESTACIONES(ESTA_ID),
	CARG_FECHA DATETIME NOT NULL,
	CARG_LITROS INT NOT NULL,
	CARG_COSTO MONEY NOT NULL	
	)


--============================================================
						--TABLA TRAMOS
--============================================================

--CREATE TABLE BD.TRAMOS(
	--TRAM_ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	--TRAM_LUGAR_CARGA_ID VARCHAR(64),
	--TRAM_LUGAR_DESCARGA_ID VARCHAR(64),
	--TRAM_TIPO VARCHAR(16), 
	--TRAM_KILOMETROS INT NOT NULL
	--)

--============================================================
						--TABLA TARIFAS LARGA DISTANCIA
--============================================================

CREATE TABLE BD.TARIFAS(
	TARI_ID INT NOT NULL PRIMARY KEY,
	TARI_NOMBRE VARCHAR(32)

	)

--============================================================
						--TABLA FILA_TARIFA
--============================================================

CREATE TABLE BD.FILA_TARIFA(
	FILA_TARI_ID INT NOT NULL FOREIGN KEY REFERENCES BD.TARIFAS(TARI_ID),
	FILA_KILOMETRO INT NOT NULL,
	FILA_PRECIO MONEY NOT NULL,
	PRIMARY KEY (FILA_TARI_ID, FILA_KILOMETRO)
	)

--============================================================
						--TABLA CLIENTES
--============================================================

CREATE TABLE BD.CLIENTES(
	CLIE_ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	CLIE_NOMBRE VARCHAR(18) NOT NULL UNIQUE, 
	CLIE_DESCRIPCION VARCHAR(40),
	CLIE_TARIFA_LARGA_DIST_ID INT NOT NULL FOREIGN KEY REFERENCES BD.TARIFAS(TARI_ID),
	CLIE_TARIFA MONEY NOT NULL,
	CLIE_IMPORTE_MIN MONEY NOT NULL
	)
	

--============================================================
						--TABLA CHOFERES
--============================================================

CREATE TABLE BD.CHOFERES(
	CHOF_ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	CHOF_CAMION_ID INT NOT NULL FOREIGN KEY REFERENCES BD.CAMIONES(CAMI_ID),
	CHOF_NOMBRE VARCHAR(30) NOT NULL UNIQUE,
	CHOF_APELLIDO VARCHAR(30)
	)

--============================================================
						--TABLA ADELANTOS
--============================================================

CREATE TABLE BD.ADELANTOS(
	ADEL_ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	ADEL_CHOFER_ID INT NOT NULL FOREIGN KEY REFERENCES BD.CHOFERES(CHOF_ID),
	ADEL_MONTO MONEY NOT NULL,
	ADEL_FECHA DATETIME NOT NULL, 
	ADEL_DESCIPCION VARCHAR(128) 
	)

--============================================================
						--TABLA REMITOS
--============================================================

CREATE TABLE BD.REMITOS(
	REMI_ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	REMI_CODIGO VARCHAR(32) NOT NULL
	)


--============================================================
						--TABLA ESTADO_VIAJE
--============================================================

CREATE TABLE BD.ESTADO_VIAJE(
	ESTA_ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	ESTA_DESCRIPCION VARCHAR(30)
	)


INSERT INTO [BD].[ESTADO_VIAJE]
           ([ESTA_DESCRIPCION])
     VALUES
           ('COBRADO'),
		   ('EN TRAMITE'),
		   ('SIN COBRAR')

-- SELECT * FROM BD.TIPOS_DE_VIAJE
--============================================================
						--TABLA VIAJES
--============================================================

CREATE TABLE BD.VIAJES(
	VIAJ_ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	VIAJ_CLIENTE_ID INT NOT NULL FOREIGN KEY REFERENCES BD.CLIENTES(CLIE_ID),
	VIAJ_CHOFER_ID INT NOT NULL FOREIGN KEY REFERENCES BD.CHOFERES(CHOF_ID),
	VIAJ_REMITO_ID INT NOT NULL FOREIGN KEY REFERENCES BD.REMITOS(REMI_ID),
	VIAJ_ESTADO_ID INT NOT NULL FOREIGN KEY REFERENCES BD.ESTADO_VIAJE(ESTA_ID),
	VIAJ_KILOMETROS INT NOT NULL,
	VIAJ_FECHA DATETIME NOT NULL,
	VIAJ_TONELADAS INT NOT NULL, 
	VIAJ_IMPORTE MONEY NOT NULL,
	VIAJ_TIPO VARCHAR(1) NOT NULL
	)



GO




-- SELECT [FILA_ID],[FILA_KILOMETROS],[FILA_PRECIO] FROM [dbo].[2014]