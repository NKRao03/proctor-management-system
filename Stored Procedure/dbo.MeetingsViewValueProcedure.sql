CREATE PROCEDURE [dbo].[MeetingsViewValueProcedure]
	
AS
	SELECT m.USN, m.pNUM, m.time, m.date, m.venue, m.issue, m.remedy
	from Meeting m
RETURN 0