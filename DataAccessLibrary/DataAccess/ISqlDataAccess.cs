
namespace DataAccessLibrary.DataAccess
{
    public interface ISqlDataAccess
    {
        Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionStringId = "Default");
        Task SaveData<T>(string storedProcedure, T parameters, string connectionStringId = "Default");
    }
}