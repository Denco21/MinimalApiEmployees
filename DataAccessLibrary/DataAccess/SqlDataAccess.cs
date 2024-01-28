using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using Dapper;
using System.Data;
namespace DataAccessLibrary.DataAccess;

public class SqlDataAccess : ISqlDataAccess
{
    private readonly IConfiguration _config;

    public SqlDataAccess(IConfiguration config)
    {
        _config = config;
    }

    public async Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure,
        U parameters,
        string connectionStringId = "Default")
    {
        using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionStringId));

        return await connection.QueryAsync<T>(storedProcedure,
                       parameters,
                                  commandType: CommandType.StoredProcedure);
    }

    public async Task SaveData<T>(string storedProcedure,
        T parameters,
        string connectionStringId = "Default")
    {
        using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionStringId));

        await connection.ExecuteAsync(storedProcedure,
                                 parameters,
                       commandType: CommandType.StoredProcedure);
    }
}
