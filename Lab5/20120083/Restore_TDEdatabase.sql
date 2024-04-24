-- load certificate with path and key give to restore database
USE master;
GO
CREATE MASTER KEY ENCRYPTION BY PASSWORD = '20120083';
GO

CREATE CERTIFICATE SQLSERVER2022_B_cert FROM FILE = 'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLSERVER2022_A\MSSQL\Backup\SQLSERVER2022_B_cert.cer'
WITH PRIVATE KEY (FILE = 'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLSERVER2022_A\MSSQL\Backup\MasterPriKey.pvk',
				DECRYPTION BY PASSWORD = '20120083')

SELECT * FROM sys.certificates;