CREATE TABLE [dbo].[Message] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [MessageText] NVARCHAR (MAX) NOT NULL,
    [DateCreated] DATETIME       NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

