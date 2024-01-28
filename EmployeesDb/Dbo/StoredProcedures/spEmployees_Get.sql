CREATE PROCEDURE [dbo].[spEmployees_Get]
	
	@Id int
AS

begin

select Id,FirstName, LastName, Position

from dbo.Employees

where Id = @Id

end

