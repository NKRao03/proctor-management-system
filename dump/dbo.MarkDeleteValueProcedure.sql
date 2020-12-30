CREATE PROCEDURE [dbo].[MarkDeleteValueProcedure]
	@USN varchar(20)
AS
	delete from Mark where USN = @USN
RETURN 0