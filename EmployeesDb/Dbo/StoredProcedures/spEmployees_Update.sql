CREATE PROCEDURE [dbo].[spEmployees_Update]
@Id int,
@FirstName nvarchar(50),
@LastName nvarchar(50),
@Position nvarchar(50)

AS

begin

update dbo.Employees
set FirstName = @FirstName, LastName = @LastName, Position = @Position
where Id = @Id


end