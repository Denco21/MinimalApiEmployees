using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data
{
    public interface IEmployeesData
    {
        Task DeleteEmployee(int id);
        Task<EmployeesModel?> GetEmployeeById(int id);
        Task<IEnumerable<EmployeesModel>> GetEmployees();
        Task InsertEmployee(EmployeesModel employee);
        Task UpdateEmployee(EmployeesModel employee);
    }
}