CREATE PROCEDURE [dbo].[MarkViewValueProcedure]
	
AS
	select m.USN, m.semester, m.Sub1, m.Sub2, m.Sub3, m.total
	from Mark m
RETURN 0