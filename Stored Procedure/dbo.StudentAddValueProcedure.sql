CREATE PROCEDURE [dbo].[StudentAddValueProcedure]
	@USN varchar(20),
	@student_name varchar(20),
	@Programme varchar(20),
	@Department varchar(20),
	@admission_year varchar(20)
AS
	insert into Student(USN, student_name, Programme, Department, admission_year) values (@USN, @student_name, @Programme, @Department, @admission_year)
RETURN 0