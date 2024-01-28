CREATE PROCEDURE [dbo].[spEmployees_GetAll]


AS

begin

select Id,FirstName, LastName, Position

from dbo.Employees


end
