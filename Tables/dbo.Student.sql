CREATE TABLE [dbo].[Student] (
    [student_name]   VARCHAR (20) NULL,
    [USN]            VARCHAR (20) NOT NULL,
    [Programme]      VARCHAR (20) NULL,
    [Department]     VARCHAR (20) NULL,
    [admission_year] VARCHAR (20) NULL,
    CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED ([USN] ASC)
);

