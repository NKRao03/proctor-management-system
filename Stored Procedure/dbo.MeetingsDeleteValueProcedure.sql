CREATE PROCEDURE [dbo].[MeetingsDeleteValueProcedure]
	@USN varchar(20)
	AS
	delete from Meeting where USN = @USN
RETURN 0