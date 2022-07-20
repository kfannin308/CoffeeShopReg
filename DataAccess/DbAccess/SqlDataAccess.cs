using System.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;
using Dapper;

//https://www.youtube.com/watch?v=dwMFg6uxQ0I&t=173s is the video about 40 minutes in

namespace DataAccess.DbAccess;

public class SqlDataAccess : ISqlDataAccess
{
    private readonly IConfiguration _config;
    public SqlDataAccess(IConfiguration config)
    {
        _config = config;
    }
    public async Task<IEnumerable<T>> LoadData<T, U>(
        string storedProcedure,
        U parameters,
        string connectionID = "Default")
    {
        using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionID));
        return await connection.QueryAsync<T>(storedProcedure, parameters,
            commandType: CommandType.StoredProcedure);
    }
    public async Task SaveData<T>(
        string storedProcedure,
        T parameters,
        string connectionID = "Default")
    {
        using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionID));
        await connection.ExecuteAsync(storedProcedure, parameters,
            commandType: CommandType.StoredProcedure);

    }
}