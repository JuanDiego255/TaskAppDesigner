using Dapper;
using TaskApp.Application;
using TaskApp.Domain;

namespace TaskApp.Infrastructure;

public class DapperUserRepository : IUserRepository
{
    private readonly SqliteConnectionFactory _factory;
    public DapperUserRepository(SqliteConnectionFactory factory) => _factory = factory;

    public async Task<IReadOnlyList<UserItem>> GetAsync(UserQuery query, CancellationToken ct)
    {
        using var con = _factory.Create();
        con.Open();

        var sql = """
        SELECT
            id as Id,
            name as Name,
            description as Description,            
            created_at_utc as CreatedAtUtcStr,
            updated_at_utc as UpdatedAtUtcStr
        FROM users
        WHERE 1=1
        """;

        var p = new DynamicParameters();

        if (!string.IsNullOrWhiteSpace(query.Name))
        {
            sql += " AND name LIKE @text ";
            p.Add("text", $"%{query.Name.Trim()}%");
        }
        

        sql += " ORDER BY name ASC;";

        var rows = await con.QueryAsync(sql, p);

        var list = new List<UserItem>();
        foreach (var r in rows)
        {
            list.Add(new UserItem
            {
                Id = (long)r.Id,
                Description = (string)r.Description,
                Name = (string)r.Name,                
                CreatedAtUtc = DateTime.Parse((string)r.CreatedAtUtcStr),
                UpdatedAtUtc = DateTime.Parse((string)r.UpdatedAtUtcStr),
            });
        }

        return list;
    }

    public async Task<UserItem?> GetByIdAsync(long id, CancellationToken ct)
    {
        using var con = _factory.Create();
        con.Open();

        var row = await con.QueryFirstOrDefaultAsync("""
        SELECT
            id as Id,
            description as Description,
            Name as Name,           
            created_at_utc as CreatedAtUtcStr,
            updated_at_utc as UpdatedAtUtcStr
        FROM users
        WHERE id = @id
        LIMIT 1;
        """, new { id });

        if (row is null) return null;

        return new UserItem
        {
            Id = (long)row.Id,
            Description = (string)row.Description,
            Name = (string)row.Name,           
            CreatedAtUtc = DateTime.Parse((string)row.CreatedAtUtcStr),
            UpdatedAtUtc = DateTime.Parse((string)row.UpdatedAtUtcStr),
        };
    }
    public async Task<int> GetTareasById(long id, CancellationToken ct)
    {
        using var con = _factory.Create();
        con.Open();

        var count = await con.ExecuteScalarAsync<int>(
            """
                SELECT COUNT(*)
                FROM tasks
                WHERE assigned_user_id = @id;
                """,
            new { id }
        );

        return count;
    }

    /// <summary>
    /// Esta función se encarga de crear nuevos usuarios (Sentencia directa en BD).   
    /// </summary>
    /// <param name="item">Item del usuario que se va a crear</param>
    /// <param name="ct">Permite cancelar la operación de una manera controlada</param>
    /// <returns>Returna el id del usuario creada</returns>
    public async Task<long> CreateAsync(UserItem item, CancellationToken ct)
    {
        using var con = _factory.Create();
        con.Open();

        var id = await con.ExecuteScalarAsync<long>("""
        INSERT INTO users(name, description, created_at_utc, updated_at_utc)
        VALUES(@Name, @Description, @CreatedAtUtc, @UpdatedAtUtc);
        SELECT last_insert_rowid();
        """, new
        {
            item.Name,
            item.Description,            
            CreatedAtUtc = item.CreatedAtUtc.ToString("O"),
            UpdatedAtUtc = item.UpdatedAtUtc.ToString("O"),
        });

        return id;
    }
    /// <summary>
    /// Esta función se encarga de actualizar el usuario seleccionado (Sentencia directa en BD).   
    /// </summary>
    /// <param name="item">Item del usuario que se va a actualizar</param>
    /// <param name="ct">Permite cancelar la operación de una manera controlada</param>
    public async Task UpdateAsync(UserItem item, CancellationToken ct)
    {
        using var con = _factory.Create();
        con.Open();

        await con.ExecuteAsync("""
        UPDATE users
        SET name=@Name,
            description=@Description,            
            updated_at_utc=@UpdatedAtUtc
        WHERE id=@Id;
        """, new
        {
            item.Id,
            item.Name,
            item.Description,            
            UpdatedAtUtc = item.UpdatedAtUtc.ToString("O"),
        });
    }
    /// <summary>
    /// Esta función se encarga de eliminar el usuario seleccionado (Sentencia directa en BD).   
    /// </summary>
    /// <param name="id">Id del usuario a eliminar</param>
    /// <param name="ct">Permite cancelar la operación de una manera controlada</param>
    public async Task DeleteAsync(long id, CancellationToken ct)
    {
        using var con = _factory.Create();
        con.Open();
        await con.ExecuteAsync("DELETE FROM users WHERE id=@id;", new { id });
    }
}