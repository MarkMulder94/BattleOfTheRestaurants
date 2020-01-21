CREATE TABLE [dbo].[KoffieBattle] (
    [Datum]        DATETIME2 (7) CONSTRAINT [DF__KoffieBat__datum__48CFD27E] DEFAULT (getdate()) NULL,
    [Groot]           INT           NULL,
    [Medium]          INT           NULL,
    [NameManager]    NVARCHAR(50)   NULL,
    [NameRestaurant] NVARCHAR(50)   NULL,
);

