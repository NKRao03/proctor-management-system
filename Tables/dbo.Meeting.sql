CREATE TABLE [dbo].[Meeting] (
    [issue]  VARCHAR (50) NULL,
    [venue]  VARCHAR (20) NULL,
    [remedy] VARCHAR (50) NULL,
    [time]   VARCHAR (5)  NOT NULL,
    [date]   DATE         NOT NULL,
    [USN]    VARCHAR (20) NOT NULL,
    [pNUM]   VARCHAR (20) NOT NULL,
    CONSTRAINT [PK_Meeting] PRIMARY KEY CLUSTERED ([pNUM] ASC, [USN] ASC, [time] ASC, [date] ASC),
    CONSTRAINT [FK_Meeting_ToTable] FOREIGN KEY ([USN]) REFERENCES [dbo].[Student] ([USN]),
    CONSTRAINT [FK_Meeting_ToTable_1] FOREIGN KEY ([pNUM]) REFERENCES [dbo].[Proctor1] ([pNUM])
);

