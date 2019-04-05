CREATE TABLE MsUser
(
	UserID UNIQUEIDENTIFIER PRIMARY KEY,
	UserName VARCHAR(50) NOT NULL,
	UserPassword VARCHAR(50) NOT NULL,
	UserNickName VARCHAR(50) NOT NULL,
	UserEmail VARCHAR(50) NOT NULL,
	UserRole INT NOT NULL,
	UserIn VARCHAR(50), 
	DateIn DATETIME, 
	UserUp VARCHAR(50), 
	DateUp DATETIME
);

ALTER TABLE MsUser
ADD UserRole INT NOT NULL

DROP TABLE MsUser

ALTER TABLE MsUser
ADD UserIn VARCHAR(50), DateIn DATE, UserUp VARCHAR(50), DateUp DATE

ALTER TABLE MsUser
ALTER COLUMN DateIn DATETIME
ALTER TABLE MsUser
ALTER COLUMN DateUp DATETIME



CREATE TABLE MsUserRole
(
	UserRoleID UNIQUEIDENTIFIER PRIMARY KEY,
	UserRole INT,
	UserRoleStatus VARCHAR(50) NOT NULL,
	UserIn VARCHAR(50), 
	DateIn DATETIME, 
	UserUp VARCHAR(50), 
	DateUp DATETIME
);
INSERT INTO MsUserRole
VALUES (NEWID(), 1, 'Admin','Oky', GETDATE(),NULL,NULL)
INSERT INTO MsUser
VALUES (NEWID(), 'DummyUser', 'DummyPass','Dummy', 'zeropyrozen@gmail.com',1,'Oky',GETDATE(),NULL,NULL)

--Example for find Role
SELECT UserRoleStatus
FROM MsUserRole
WHERE UserRole = (
	SELECT UserRole
	FROM MsUser
	WHERE UserNickName = 'Dummy'
)

SELECT *
FROM MsUser

-- =============================================
-- Author		: Oky
-- Create Date	: 5 April 2019
-- Description	: User Login
-- =============================================
ALTER PROCEDURE ln_General_Login
@Username VARCHAR(50),
@Password VARCHAR(50)
AS
BEGIN
	SELECT UserID, UserName, UserPassword, UserNickName, UserEmail, UserRole
	FROM MsUser
	WHERE UserName = @Username AND UserPassword = @Password
END

ln_General_Login 'DummyUser', 'DummyPass'