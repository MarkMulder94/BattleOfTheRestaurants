CREATE TABLE [dbo].[Restaurant] (
    [RestaurantId] INT          IDENTITY (1, 1) NOT NULL,
    [RestName]     VARCHAR (20) NULL,
    [City]         VARCHAR (50) NULL,
    [Straat]       VARCHAR (20) NULL,
    [Huisnummer]   INT          NULL,
    CONSTRAINT [PK_Restaurant] PRIMARY KEY CLUSTERED ([RestaurantId] ASC)
);

