CREATE PROCEDURE [dbo].[StudentDeleteValueProcedure]
	@USN varchar(20)
AS
	delete from Student where USN = @USN
RETURN 0