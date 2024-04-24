--
USE [master]
GO
CREATE LOGIN [BDAdmin] WITH PASSWORD=N' ', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
CREATE LOGIN [BDBK] WITH PASSWORD=N' ', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
CREATE LOGIN [BDU01] WITH PASSWORD=N' ', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
CREATE LOGIN [BDProfile] WITH PASSWORD=N' ', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
CREATE LOGIN [BDRead] WITH PASSWORD=N' ', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO

DECLARE @i INT = 2
WHILE @i <= 4
BEGIN
    DECLARE @name NVARCHAR(50) = 'BDU0' + CAST(@i AS NVARCHAR(2))
    DECLARE @sql NVARCHAR(200) = 'CREATE LOGIN ' + QUOTENAME(@name) + ' WITH PASSWORD = N'' ''' + ', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF'
    EXEC(@sql)
    SET @i = @i + 1
END
GO

----------------------------------
USE [QLBongDa]
GO

-- create grant BDAdmin user
CREATE USER [BDAdmin] FOR LOGIN [BDAdmin]
GO
CREATE USER [BDBK] FOR LOGIN [BDBK]
GO
CREATE USER [BDProfile] FOR LOGIN [BDProfile]
GO
CREATE USER [BDRead] FOR LOGIN [BDRead]
GO
CREATE USER [BDU01] FOR LOGIN [BDU01]
GO 

DECLARE @i INT = 2
WHILE @i <= 4
BEGIN
    DECLARE @name NVARCHAR(50) = 'BDU0' + CAST(@i AS NVARCHAR(2))
    DECLARE @sql NVARCHAR(200) = 'CREATE USER ' + QUOTENAME(@name) + ' FOR LOGIN ' + QUOTENAME(@name)
    EXEC(@sql)
    SET @i = @i + 1
END
GO

-- set role
USE [QLBongDa]
GO

-- BDAdmin
ALTER ROLE [db_owner] ADD MEMBER [BDAdmin]
GO

-- BDBK
ALTER ROLE [db_backupoperator] ADD MEMBER [BDBK]
GO

---- Grant permission to backup a specific database
--GRANT BACKUP DATABASE ON [QLBongDa] TO BDBK;

---- Grant permission to backup the transaction log of a specific database
--GRANT BACKUP LOG ON [QLBongDa] TO BDBK;

-- BDRead
ALTER ROLE [db_datareader] ADD MEMBER [BDRead]
GO

-- BDU01
--ALTER ROLE [db_datawriter] ADD MEMBER [BDU01]
--GO
GRANT CREATE TABLE TO BDU01
GO
GRANT ALTER ON SCHEMA::dbo TO BDU01;
GO

-- 
--REVOKE CREATE TABLE FROM BDU01;

-- BDU02
--ALTER ROLE [db_datawriter] ADD MEMBER [BDU02]
--GO
DECLARE @sqlCommandUpdate NVARCHAR(MAX)
DECLARE @sqlCommandSelect NVARCHAR(MAX)

SELECT @sqlCommandUpdate = COALESCE(@sqlCommandUpdate, '') + 'GRANT UPDATE ON ' + QUOTENAME(SCHEMA_NAME(schema_id)) + '.' + QUOTENAME(name) + ' TO ' + 'BDU02' + ';' + CHAR(13)
FROM sys.tables
SELECT @sqlCommandSelect = COALESCE(@sqlCommandSelect, '') + 'GRANT SELECT ON ' + QUOTENAME(SCHEMA_NAME(schema_id)) + '.' + QUOTENAME(name) + ' TO ' + 'BDU02' + ';' + CHAR(13)
FROM sys.tables

EXEC sp_executesql @sqlCommandUpdate
EXEC sp_executesql @sqlCommandSelect

GRANT ALTER ON SCHEMA::dbo TO BDU02;
GO

-- test BDU02

--USE QLBongDa
--UPDATE QUOCGIA
--SET TENQG = N'Việt Nam'
--WHERE MAQG = N'VN'

--INSERT [dbo].[TINH] ([MATINH], [TENTINH]) VALUES (N'GLx', N'Gia Laix')

--

-- BDU03
GRANT DELETE, INSERT, SELECT, UPDATE ON [dbo].[CAULACBO] TO [BDU03]
GO
GRANT ALTER ON SCHEMA::dbo TO [BDU03];
GO

-- BDU03 TEST
--USE QLBongDa

--UPDATE CauLacBo
--SET [TENCLB] = N'BECAMEX BÌNH DƯƠNG' --BECAMEX BÌNH DƯƠNG
--WHERE [MACLB] = N'BBD'

--INSERT [dbo].[CAULACBO] ([MACLB], [TENCLB], [MASAN], [MATINH]) VALUES (N'AHIHI', N'X', N'GD', N'BD')
--DELETE FROM [dbo].[CAULACBO] WHERE [MACLB] = N'AHIHI'
---- TEST ON ANOTHER TABLE
----INSERT [TINH] ([MATINH], [TENTINH]) VALUES (N'GLx', N'Gia Laix')
--

-- BDU04
-- Grant SELECT, INSERT, UPDATE, DELETE permissions on the table
GRANT SELECT, INSERT, UPDATE, DELETE ON [dbo].[CAUTHU] TO BDU04;

-- Grant SELECT permission on all columns except NGAYSINH
DENY SELECT ON [dbo].[CAUTHU]([NGAYSINH]) TO BDU04;

-- Grant UPDATE permission on all columns except VITRI
DENY UPDATE ON [dbo].[CAUTHU]([VITRI]) TO BDU04;
GO
-- CHECK BDU04
--USE QLBongDa

----SELECT *
----FROM [CAUTHU]

----UPDATE [CAUTHU]
----SET [VITRI] = N'Thủ môn' -- TIỀN VỆ
----WHERE [MACT] = N'1'

----UPDATE CauLacBo
----SET [TENCLB] = N'BECAMEX BÌNH DƯƠNGc' --BECAMEX BÌNH DƯƠNG
----WHERE [MACLB] = N'BBD'

--SELECT [MACT], [HOTEN], [VITRI], [DIACHI], [MACLB], [MAQG], [SO]
--FROM [CAUTHU]

--UPDATE [CAUTHU]
--SET [SO] = 17 --17
--WHERE [MACT] = N'1'
--

-- BDProfile
USE MASTER
GO
GRANT ALTER TRACE TO BDProfile
GO