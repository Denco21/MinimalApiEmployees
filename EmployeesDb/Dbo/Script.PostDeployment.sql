
if not exists (select * from dbo.Employees)

begin 

insert into dbo.Employees (FirstName, LastName, Position)
values ('John', 'Deep', 'Manager'),

('Johanna', 'Klingberg', 'C-sharp Developer'),

('Dennis', 'Fratello', 'Python Developer'),

('Mohammed', 'Smith', 'Java Developer'),

('Rosa', 'Berg', 'React Developer');

end