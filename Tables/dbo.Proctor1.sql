CREATE TABLE [dbo].[Proctor1] (
    [pNUM]         VARCHAR (20) NOT NULL,
    [proctor_name] VARCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([pNUM] ASC),
    CONSTRAINT [FK_Proctor1_ToTable] FOREIGN KEY ([pNUM]) REFERENCES [dbo].[Credentials] ([pNUM])
);

