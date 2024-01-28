CREATE PROCEDURE [dbo].[spEmployees_Insert]
@FirstName nvarchar(50),
@LastName nvarchar(50),
@Position nvarchar(50)

AS

begin

insert into dbo.Employees (FirstName, LastName, Position)
values (@FirstName, @LastName, @Position); 


end