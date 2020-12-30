CREATE PROCEDURE [dbo].[MarkAddValueProcedure]
	@sub1 int,
	@sub2 int,
	@sub3 int,
	@semester varchar(20),
	@USN varchar(20)
	@sub4 int, 
	@sub5 int, 
	@sub6 int
AS
	insert into Mark(USN, Sub1, Sub2, Sub3, Sub4, Sub5, Sub6, semester) values (@USN, @sub1, @sub2, @sub3, @sub4, @sub5, @sub6, @semester)
RETURN 0