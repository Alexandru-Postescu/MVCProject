CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserId] INT NOT NULL, 
    [Username] NVARCHAR(50) NOT NULL, 
    [FirmName] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(150) NOT NULL, 
    [PhoneNumber] NVARCHAR(50) NOT NULL
)
