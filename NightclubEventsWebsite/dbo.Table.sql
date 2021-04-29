CREATE TABLE [dbo].[Events] (
    [EventID]    INT           IDENTITY (1, 1) NOT NULL,
    [EventTitle] VARCHAR (100) NOT NULL,
    [ClubName]   VARCHAR (100) NOT NULL,
    [DJName]     VARCHAR (100) NULL,
    [EventDate]  DATETIME2 (7) NOT NULL,
    [StartTime]  DATETIME2 (7) NOT NULL,
    [EndTime]    DATETIME2 (7) NULL,
    CONSTRAINT [PK_Events] PRIMARY KEY CLUSTERED ([EventID] ASC)
);

