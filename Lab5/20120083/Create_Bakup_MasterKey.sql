/*---------------------------------------------------------- 
MASV: 20120083
HO TEN: Nguyễn Trọng Hiếu
LAB: 05
NGAY: 05/05/2023
----------------------------------------------------------*/ 
-- CAC CAU LENH DE THUC HIEN MA HOA

USE master
GO

CREATE MASTER KEY Encryption BY PASSWORD = '20120083'
GO
CREATE CERTIFICATE SQLSERVER2022_B_cert WITH SUBJECT = 'SQLSERVER2022_B_cert'
GO

USE QLBongDa
GO

CREATE DATABASE ENCRYPTION KEY
WITH ALGORITHM = AES_256
ENCRYPTION BY SERVER CERTIFICATE SQLSERVER2022_B_cert
GO
ALTER DATABASE QLBongDa SET ENCRYPTION ON
GO

USE master
GO

-- save certificate and key to path given C:\BMCSDL_Lab5\
BACKUP CERTIFICATE SQLSERVER2022_B_cert
TO FILE = 'C:\BMCSDL_Lab5\SQLSERVER2022_B_cert.cer'
	WITH PRIVATE KEY(FILE = 'C:\BMCSDL_Lab5\MasterPriKey.pvk',
	ENCRYPTION BY PASSWORD = '20120083')

SELECT * FROM sys.certificates;