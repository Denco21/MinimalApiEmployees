CREATE TABLE [dbo].[Employees]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NCHAR(10) NOT NULL, 
    [Position] NVARCHAR(50) NOT NULL
)
