CREATE PROCEDURE [dbo].[StudentSearchValueProcedure]
	@USN varchar(20)
AS
	SELECT s.USN, s.student_name, s.Programme, s.Department, s.admission_year 
	from Student s 
	where s.USN = @USN
RETURN 0