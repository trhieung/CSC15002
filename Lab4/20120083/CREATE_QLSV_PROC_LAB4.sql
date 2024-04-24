
/*-------------------------------------------------------------
	MASV: 20120083
	HO TEN: NGUYỄN TRỌNG HIẾU
	LAB: 03
	NGAY: 04/04/2023

	PREREQUISITES: RUN AFTER FILE BEFORE DOING WITH THIS FILES
	1. CREATE_QLSV_DB.sql
	2. CREATE_QLSV_TABLE.sql
-------------------------------------------------------------*/

-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<NGUYEN TRONG HIEU>
-- Create date: <04,04,2023>
-- Description:	<BAI TAP LAB 3>
-- =============================================
USE QLSV
GO
SELECT * FROM sys.tables
GO
---- i.
CREATE PROCEDURE SP_INS_ENCRYPT_SINHVIEN
    @masv NVARCHAR(20),
    @hoten NVARCHAR(100),
    @ngaysinh DATETIME,
    @diachi NVARCHAR(200),
    @malop VARCHAR(20),
    @tendn NVARCHAR(100),
    @matkhau VARCHAR(100)
AS
BEGIN
    DECLARE @encrypted_password VARBINARY(128);
    SET @encrypted_password = CONVERT(VARBINARY(128), @matkhau);
    
    INSERT INTO SINHVIEN (MASV, HOTEN, NGAYSINH, DIACHI, MALOP, TENDN, MATKHAU)
    VALUES (@masv, @hoten, @ngaysinh, @diachi, @malop, @tendn, @encrypted_password);
END

---- ii.--------------------------------------------------------
CREATE PROCEDURE SP_INS_ENCRYPT_NHANVIEN
    @MANV VARCHAR(20),
    @HOTEN NVARCHAR(100),
    @EMAIL VARCHAR(20),
    @LUONG VARCHAR(MAX),
    @TENDN NVARCHAR(100),
    @MATKHAU VARCHAR(MAX)
AS
BEGIN
    DECLARE @binaryLuong VARBINARY(MAX);
	DECLARE @binaryMathau VARBINARY(MAX);

    -- encrypt LUONG using AES 256
    SET @binaryLuong = CONVERT(VARBINARY(MAX), @LUONG);
	SET @binaryMathau = CONVERT(VARBINARY(MAX), @MATKHAU);
    
    -- insert data into NHANVIEN table
    INSERT INTO NHANVIEN(MANV, HOTEN, EMAIL, LUONG, TENDN, MATKHAU)
    VALUES(@MANV, @HOTEN, @EMAIL, @binaryLuong, @TENDN, @binaryMathau);
END

exec SP_INS_ENCRYPT_NHANVIEN @manv=N'NV02',@hoten=N'Q',@email=N'Q',@luong=N'nN/myTeyqfMWNX5Mte8pdg==',@tendn=N'Q',@matkhau=N'wxVuANPCWIxjng089oISWLBXYcc='

-----iii.----------------------------------------------------------
CREATE PROCEDURE SP_SEL_ENCRYPT_NHANVIEN
AS
BEGIN 
	SELECT MANV, HOTEN, EMAIL, CONVERT(VARCHAR(MAX), LUONG) AS LUONG, TENDN, CONVERT(VARCHAR(MAX), MATKHAU) AS MATKHAU
	FROM dbo.NHANVIEN
END

EXEC SP_SEL_ENCRYPT_NHANVIEN

---------------------------------------------------------------------

---- support procedure---------------------------------------

CREATE PROCEDURE SP_GET_ENCRYPT_NHANVIEN
	@USERNAME NVARCHAR(100),
	@MATKHAU VARCHAR(MAX)
AS
BEGIN 
	SELECT MANV, HOTEN, EMAIL, CONVERT(VARCHAR(MAX), LUONG) AS LUONG, TENDN, CONVERT(VARCHAR(MAX), MATKHAU) AS MATKHAU
	FROM dbo.NHANVIEN
	WHERE TENDN = @USERNAME AND MATKHAU = CONVERT(VARBINARY(MAX), @MATKHAU)
END

EXEC SP_GET_ENCRYPT_NHANVIEN 'Q', N'wxVuANPCWIxjng089oISWLBXYcc='
exec SP_GET_ENCRYPT_NHANVIEN @USERNAME=N'q',@MATKHAU=N'IuocZJyClGqm5Hnh/9Mh5KMYsbA='

--------------------------------------------------------------------------------------------------------
CREATE PROCEDURE SP_CHECK_ENCRYPT_NHANVIEN
	@USERNAME NVARCHAR(100),
	@MATKHAU VARCHAR(MAX)
AS
BEGIN
	IF EXISTS(SELECT * FROM dbo.NHANVIEN WHERE TENDN = @username AND MATKHAU = CONVERT(VARBINARY(MAX), @MATKHAU))
        SELECT 'Success' AS Result
    ELSE
        SELECT 'Fail' AS Result
END

EXEC SP_CHECK_ENCRYPT_NHANVIEN N'Q', N'wxVuANPCWIxjng089oISWLBXYcc='
--------------------------------------------------------------------------------------------------------
CREATE PROCEDURE dbo.SP_INS_SINHVIEN
    @MASV NVARCHAR(20),
    @HOTEN NVARCHAR(100),
    @NGAYSINH DATETIME,
    @DIACHI NVARCHAR(200),
    @MALOP VARCHAR(20),
    @TENDN NVARCHAR(100),
    @MATKHAU VARCHAR(100)
AS
BEGIN
    INSERT INTO SINHVIEN (MASV, HOTEN, NGAYSINH, DIACHI, MALOP, TENDN, MATKHAU)
    VALUES (@MASV, @HOTEN, @NGAYSINH, @DIACHI, @MALOP, @TENDN, (CONVERT(VARBINARY(128), HASHBYTES('MD5', @MATKHAU))))
END
GO

----------------------------------------------------------------------------------------------------
CREATE PROCEDURE dbo.SP_INS_NHANVIEN
    @MANV VARCHAR(20),
    @HOTEN NVARCHAR(100),
	@EMAIL VARCHAR(20),
	@LUONG NUMERIC,
	@TENDN NVARCHAR(100),
	@MATKHAU VARCHAR(100)
AS
BEGIN
    -- Mã hóa thuộc tính LUONG sử dụng thuật toán AES 256 với khóa mã hóa là '20120083'
    DECLARE @LUONG_VARBINARY VARBINARY(256)
    SET @LUONG_VARBINARY = CONVERT(VARBINARY(256), @LUONG)
    SET @LUONG_VARBINARY = EncryptByPassPhrase('20120083', @LUONG_VARBINARY)
    
    -- Mã hóa thuộc tính MATKHAU sử dụng SHA1
    DECLARE @MATKHAU_VARBINARY VARBINARY(50)
    SET @MATKHAU_VARBINARY = CONVERT(VARBINARY(100), @MATKHAU)
    SET @MATKHAU_VARBINARY = HASHBYTES('SHA1', @MATKHAU_VARBINARY)
    
    -- Thực hiện chèn dữ liệu vào bảng NHANVIEN
    INSERT INTO NHANVIEN (MANV, HOTEN, EMAIL, LUONG, TENDN, MATKHAU)
    VALUES (@MANV, @HOTEN, @EMAIL, @LUONG_VARBINARY, @TENDN, @MATKHAU_VARBINARY)
END
GO

----------------------------------------------------------------------------------------------------
CREATE PROCEDURE dbo.SP_SEL_NHANVIEN
AS
BEGIN
    SELECT MANV, HOTEN, EMAIL, CAST(DECRYPTBYPASSPHRASE('20120083', LUONG) AS numeric) AS LUONGCB
	FROM dbo.NHANVIEN
END
GO

----
EXEC SP_INS_SINHVIEN N'SV01', 'NGUYEN VAN A', '1/1/1990', '280 AN DUONG VUONG', 'CNTT-K35', 'NVA', '123456'
EXEC SP_INS_NHANVIEN N'NV01', 'NGUYEN VAN A', 'NVA@', 3000000, 'NVA', 'abcd12'
EXEC SP_SEL_NHANVIEN

-------------------------------------------------------------------------------------------------------
CREATE PROCEDURE dbo.SP_CheckLogin_SINHVIEN
    @username NVARCHAR(100),
    @password VARCHAR(100)
AS
BEGIN
    IF EXISTS(SELECT * FROM SINHVIEN WHERE TENDN = @username AND MATKHAU = (CONVERT(VARBINARY(128), HASHBYTES('MD5', @password))))
        SELECT 'Success' AS Result
    ELSE
        SELECT 'Fail' AS Result
END

----------------------------------------------------------------------------------------------------
CREATE PROCEDURE dbo.SP_CheckLogin_NHANVIEN
    @username NVARCHAR(100),
    @password VARCHAR(100)
AS
BEGIN
    IF EXISTS(SELECT * FROM dbo.NHANVIEN WHERE TENDN = @username AND MATKHAU = (HASHBYTES('SHA1', CONVERT(VARBINARY(100), @password))))
        SELECT 'Success' AS Result
    ELSE
        SELECT 'Fail' AS Result
END

----------------------------------------------------------------------------------------------------
CREATE PROCEDURE dbo.SP_CheckLogin
    @username NVARCHAR(100),
    @password VARCHAR(100)
AS
BEGIN
    IF EXISTS(SELECT * FROM dbo.SINHVIEN WHERE TENDN = @username AND MATKHAU = (CONVERT(VARBINARY(128), HASHBYTES('MD5', @password))))
        SELECT 'Success' AS ResulT
    ELSE IF EXISTS(SELECT * FROM dbo.NHANVIEN WHERE TENDN = @username AND MATKHAU = (HASHBYTES('SHA1', CONVERT(VARBINARY(100), @password))))
        SELECT 'Success' AS Result
    ELSE
        SELECT 'Fail' AS Result
END

EXEC SP_CheckLogin_SINHVIEN N'NVA', '123456'
EXEC SP_CheckLogin_NHANVIEN N'NVA', 'abcd12'

EXEC SP_CheckLogin N'NVA', '123456'
EXEC SP_CheckLogin N'NVA', 'abcd12'

-- DROP PROCEDURES
--DROP PROCEDURE SP_INS_SINHVIEN;
--DROP PROCEDURE dbo.SP_SEL_NHANVIEN

SELECT DB_NAME() AS [Current Database];


------------------------------------------------------------------------------------------------------
CREATE PROCEDURE dbo.SP_GET_INFOR
    @username NVARCHAR(100),
    @password VARCHAR(100)
AS
BEGIN
	SELECT * 
	FROM dbo.SINHVIEN 
	WHERE TENDN = @username AND MATKHAU = (CONVERT(VARBINARY(128), @password))
END

EXEC dbo.SP_GET_INFOR N'NVA', '123456'