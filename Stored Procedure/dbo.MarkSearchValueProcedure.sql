CREATE PROCEDURE [dbo].[MarkSearchValueProcedure]
	@USN varchar(20)
AS
	select m.USN, m.semester, m.Sub1, m.Sub2, m.Sub3, m.Sub4, m.Sub5, m.Sub6, m.total
	from Mark m
	where m.USN = @USN
RETURN 0