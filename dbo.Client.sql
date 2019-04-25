CREATE TABLE [dbo].[Client] (
    [ClientID]   NVARCHAR (128) NOT NULL,
    [ClientName] NVARCHAR (MAX) NOT NULL,
    [Phone]      NVARCHAR (MAX) NOT NULL,
    [Email]      NVARCHAR (MAX) NOT NULL,
    [Insurance]  BIT            NOT NULL,
    CONSTRAINT [PK_dbo.Client] PRIMARY KEY CLUSTERED ([ClientID] ASC)
);

