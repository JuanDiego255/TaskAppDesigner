using Microsoft.Data.Sqlite;
using System.Data;

namespace TaskApp.Infrastructure;
/// <summary>
/// Crea la conexión Sqlite
/// </summary>
public class SqliteConnectionFactory
{
    private readonly string _cs;
    public SqliteConnectionFactory(string connectionString) => _cs = connectionString;

    public IDbConnection Create() => new SqliteConnection(_cs);
}