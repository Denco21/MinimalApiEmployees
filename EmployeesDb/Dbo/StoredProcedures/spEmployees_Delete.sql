CREATE PROCEDURE [dbo].[spEmployees_Delete]

@Id int

AS

begin

delete from dbo.Employees

where Id = @Id

end



	
