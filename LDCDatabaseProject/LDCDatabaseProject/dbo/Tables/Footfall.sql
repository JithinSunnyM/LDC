CREATE TABLE [dbo].[Footfall] (
    [WeekNo]     INT NULL,
    [PremisesId] INT NULL,
    [Count]      INT NULL,
    CONSTRAINT [FK_Footfall_Premises] FOREIGN KEY ([PremisesId]) REFERENCES [dbo].[Premises] ([Id])
);

