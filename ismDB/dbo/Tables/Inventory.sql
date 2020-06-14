CREATE TABLE [dbo].[Inventory]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[Manufacturer] NVARCHAR(50) NOT NULL, 
	[SerialNumber] NVARCHAR(50) NULL, 
	[MacAddress] NVARCHAR(17) NULL, 
	[AssignedUser] INT NOT NULL, 
	[EnteredAgent] NVARCHAR(50) NOT NULL, 
	[AgentCheckOut] NVARCHAR(50) NULL

)
