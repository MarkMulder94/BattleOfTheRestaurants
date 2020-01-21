CREATE TABLE [dbo].[Manager] (
    [ManagerId]    INT          IDENTITY (1, 1) NOT NULL,
    [FirstName]    VARCHAR (50) NULL,
    [LastName]     VARCHAR (50) NULL,
    [EmailAddress]         VARCHAR (50) NULL,
    [RestaurantId] INT          NULL,
    PRIMARY KEY CLUSTERED ([ManagerId] ASC),
    CONSTRAINT [FK_ManagerRestaurant] FOREIGN KEY ([RestaurantId]) REFERENCES [dbo].[Restaurant] ([RestaurantId])
);

