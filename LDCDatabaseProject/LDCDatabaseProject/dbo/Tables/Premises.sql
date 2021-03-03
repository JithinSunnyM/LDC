CREATE TABLE [dbo].[Premises] (
    [Id]         INT          NOT NULL,
    [Street]     VARCHAR (50) NULL,
    [PostCode]   VARCHAR (50) NULL,
    [StreetNo]   VARCHAR (50) NULL,
    [BusinessId] INT          NULL,
    CONSTRAINT [PK_Premises] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Premises_Businesses] FOREIGN KEY ([BusinessId]) REFERENCES [dbo].[Businesses] ([Id])
);

