CREATE TABLE [dbo].[Books]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] TEXT NOT NULL, 
    [Author] TEXT NOT NULL, 
    [Location] TEXT NULL, 
    [Release] DATE NULL
)
