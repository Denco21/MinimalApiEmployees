using DataAccessLibrary.DataAccess;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data;

public class EmployeesData : IEmployeesData
{
    private readonly ISqlDataAccess _db;

    public EmployeesData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<EmployeesModel>> GetEmployees() =>
        _db.LoadData<EmployeesModel, dynamic>("dbo.spEmployees_GetAll", new { });

    public async Task<EmployeesModel?> GetEmployeeById(int id)
    {
        var results = await _db.LoadData<EmployeesModel,
            dynamic>("dbo.spEmployees_Get", new { Id = id });

        return results.FirstOrDefault();
    }

    // SaveData is used for insert, update and delete
    public Task InsertEmployee(EmployeesModel employee) => // ingen id i insert da den er autoincrement
         _db.SaveData("dbo.spEmployees_Insert", new { employee.FirstName, employee.LastName, employee.Position });

    public Task UpdateEmployee(EmployeesModel employee) =>
        _db.SaveData("dbo.spEmployees_Update", employee);


    public Task DeleteEmployee(int id) =>
        _db.SaveData("dbo.spEmployees_Delete", new { Id = id });

}
