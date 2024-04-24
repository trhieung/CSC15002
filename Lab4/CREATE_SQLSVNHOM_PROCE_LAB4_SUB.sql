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
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

USE	QLSVNhomLab4
GO

CREATE PROCEDURE SP_INS_PUBLIC_ENCRYPT_NHANVIEN
	@MANV VARCHAR(20),
	@HOTEN NVARCHAR(100),
	@EMAIL VARCHAR(20),
	@LUONG VARCHAR(MAX),
	@TENDN NVARCHAR(100),
	@MK NVARCHAR(MAX),
	@PUB VARCHAR(MAX)
AS
BEGIN
	INSERT INTO NHANVIEN VALUES (@MANV, @HOTEN, @EMAIL, CONVERT(VARBINARY(MAX), @LUONG), @TENDN, CONVERT(VARBINARY(MAX), @MK), @PUB)
END
GO

CREATE PROCEDURE SP_SEL_PUBLIC_ENCRYPT_NHANVIEN
	@TENDN NVARCHAR(100),
	@MK NVARCHAR(MAX)
AS
BEGIN
	DECLARE @PASS VARBINARY(MAX) = CONVERT(VARBINARY(MAX), @MK)

	SELECT MANV, HOTEN, EMAIL, CONVERT(VARCHAR(MAX), LUONG) AS LUONG
	FROM NHANVIEN
	WHERE TENDN = @TENDN AND MATKHAU = @PASS
END
GO

----------------------------------SUPPORT PROCEDURE----------------------------------
CREATE PROCEDURE SP_SEL_PUBLIC_ENCRYPT_ALL_NHANVIEN
AS
BEGIN
	SELECT MANV, HOTEN, CONVERT(VARCHAR(MAX), LUONG) AS LUONG, EMAIL
	FROM NHANVIEN
END
GO

EXEC SP_SEL_PUBLIC_ENCRYPT_ALL_NHANVIEN

CREATE PROCEDURE SP_CHECK_ENCRYPT_NHANVIEN
	@USERNAME NVARCHAR(100),
	@MATKHAU NVARCHAR(MAX)
AS
BEGIN
	IF EXISTS(SELECT * FROM dbo.NHANVIEN WHERE TENDN = @username AND MATKHAU = CONVERT(VARBINARY(MAX), @MATKHAU))
        SELECT 'Success' AS Result
    ELSE
        SELECT 'Fail' AS Result
END
GO

SELECT CONVERT(NVARCHAR(MAX), MATKHAU) AS MK FROM NHANVIEN
exec SP_SEL_PUBLIC_ENCRYPT_NHANVIEN @TENDN=N'NV06',@MK=N'ZvY1r+34HR4YwQpLLYALmFngStQ='