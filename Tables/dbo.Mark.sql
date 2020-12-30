CREATE TABLE [dbo].[Mark] (
    [USN]      VARCHAR (20) NOT NULL,
    [semester] VARCHAR (20) NOT NULL,
    [Sub1]     INT          NULL,
    [Sub2]     INT          NULL,
    [Sub3]     INT          NULL,
    [total]    INT          NULL,
    CONSTRAINT [PK_Marks] PRIMARY KEY CLUSTERED ([USN] ASC, [semester] ASC)
);


GO

CREATE TRIGGER [dbo].[Total_Calc]
    ON [dbo].[Mark]
    FOR INSERT
    AS
    BEGIN
        declare @sub1 int 
		declare	@sub2 int 
		declare	@sub3 int
		declare	@total int
	    
		select @sub1 = Sub1 from inserted 
		select @sub2 = Sub2 from inserted 
		select @sub3 = Sub3 from inserted 

	    set @total = @sub1 + @sub2 + @sub3 
		update Mark set total = @total / 3
    END