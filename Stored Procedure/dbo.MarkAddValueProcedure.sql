CREATE PROCEDURE [dbo].[MarkAddValueProcedure]
	@sub1 int,
	@sub2 int,
	@sub3 int,
	@semester varchar(20),
	@USN varchar(20)
AS
	insert into Mark(USN, Sub1, Sub2, Sub3, semester) values (@USN, @sub1, @sub2, @sub3, @semester)
RETURN 0