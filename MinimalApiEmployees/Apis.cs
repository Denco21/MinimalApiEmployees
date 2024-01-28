using DataAccessLibrary.Data;
using DataAccessLibrary.Models;


namespace MinimalApiEmployees;

public static class Apis
{
    public static void MapApis(this WebApplication app)
    {
        app.MapGet("/Employees", GetEmployees);
        app.MapGet("/Employees/{id}", GetEmployeeById);
        app.MapPost("/Employees", InsertEmployee);
        app.MapPut("/Employees", UpdateUser);
        app.MapDelete("/Employees/", DelteEmployee);

      
    }

    private static async Task<IResult> GetEmployees(IEmployeesData employee)
    {
        try
        {
            return Results.Ok(await employee.GetEmployees());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }

    }

    private static async Task<IResult> GetEmployeeById(IEmployeesData employee, int id)
    {
        try
        {
            var result = await employee.GetEmployeeById(id);
            if (result is not null)
            {
                return Results.Ok(result);
            }
            else
            {
                return Results.NotFound();
            }
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> InsertEmployee(IEmployeesData employee, EmployeesModel emp)
    {
        try
        {
            await employee.InsertEmployee(emp);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> UpdateUser(IEmployeesData employee, EmployeesModel emp)
    {
        try
        {
            await employee.UpdateEmployee(emp);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }


    private static async Task<IResult> DelteEmployee (IEmployeesData employee, int id)
    {
        try
        {
            await employee.DeleteEmployee(id);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    


}
