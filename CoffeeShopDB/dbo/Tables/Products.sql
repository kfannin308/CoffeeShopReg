CREATE TABLE [dbo].[Products]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [name] NVARCHAR(20) NOT NULL, 
    [description] NVARCHAR(30) NULL, 
    [price] DECIMAL(10, 2) NOT NULL, 
    [category] NVARCHAR(10) NOT NULL
)
