USE [IL_MENDO]
GO

INSERT INTO [BD].[TARIFAS]
           ([TARI_ID]
           ,[TARI_NOMBRE])
     VALUES
           (1,'Calcic Noviembre 2014')


INSERT INTO [BD].[FILA_TARIFA]
           ([FILA_TARI_ID]
           ,[FILA_KILOMETRO]
           ,[FILA_PRECIO])
     select 1, FILA_KILOMETROS, FILA_PRECIO FROM dbo.[2014]



GO


