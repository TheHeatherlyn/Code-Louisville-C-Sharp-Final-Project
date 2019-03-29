CREATE TABLE [dbo].[Table] (
    [Name]   NVARCHAR (50)  NOT NULL,
    [Phone]  NVARCHAR (50)  NULL,
    [Street] NVARCHAR (MAX) NULL,
    [City]   NVARCHAR (50)  NULL,
    [State]  NVARCHAR (50)  NULL,
    [Zip]    NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Table] PRIMARY KEY CLUSTERED ([Name] ASC)
);

