CREATE TABLE [dbo].[tblStudent]
(
	[studentID] NCHAR(10) NOT NULL PRIMARY KEY, 
    [studentName] VARCHAR(50) NULL, 
    [studentIC] VARCHAR(50) NULL, 
    [studentContact] BIGINT NULL, 
    [studentAddress] VARCHAR(50) NULL
)
