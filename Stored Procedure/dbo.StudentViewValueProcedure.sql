CREATE PROCEDURE [dbo].[StudentViewValueProcedure]
AS
	SELECT s.student_name, s.USN, s.Programme, s.Department, s.admission_year
	FROM Student s
RETURN 0