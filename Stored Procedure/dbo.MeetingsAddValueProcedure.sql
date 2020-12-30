CREATE PROCEDURE [dbo].[MeetingsAddValueProcedure]
	@USN varchar(20),
	@pNUM varchar(20),
	@time varchar(20),
	@date date,
	@venue varchar(20),
	@issue varchar(50),
	@remedy varchar(50)
AS
	insert into Meeting(USN, pNUM, time, date, venue, issue, remedy) values (@USN, @pNUM, @time, @date, @venue, @issue, @remedy)
RETURN 0