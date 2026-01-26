using Dapper;
using TaskApp.Application;
using TaskApp.Domain;

namespace TaskApp.Infrastructure;

public class DapperTaskRepository : ITaskRepository
{
    private readonly SqliteConnectionFactory _factory;
    public DapperTaskRepository(SqliteConnectionFactory factory) => _factory = factory;

    public async Task<IReadOnlyList<TaskItem>> GetAsync(TaskQuery query, CancellationToken ct)
    {
        using var con = _factory.Create();
        con.Open();

        var sql = """
        SELECT
            id as Id,
            description as Description,
            assigned_user as AssignedUser,
            status as Status,
            priority as Priority,
            due_date as DueDateStr,
            notes as Notes,
            created_at_utc as CreatedAtUtcStr,
            updated_at_utc as UpdatedAtUtcStr
        FROM tasks
        WHERE 1=1
        """;

        var p = new DynamicParameters();

        if (!string.IsNullOrWhiteSpace(query.Text))
        {
            sql += " AND description LIKE @text ";
            p.Add("text", $"%{query.Text.Trim()}%");
        }
        if (query.Status is not null)
        {
            sql += " AND status = @status ";
            p.Add("status", (int)query.Status.Value);
        }
        if (query.Priority is not null)
        {
            sql += " AND priority = @priority ";
            p.Add("priority", (int)query.Priority.Value);
        }
        if (!string.IsNullOrWhiteSpace(query.AssignedUser))
        {
            sql += " AND assigned_user = @user ";
            p.Add("user", query.AssignedUser.Trim());
        }

        sql += " ORDER BY due_date ASC;";

        var rows = await con.QueryAsync(sql, p);

        var list = new List<TaskItem>();
        foreach (var r in rows)
        {
            list.Add(new TaskItem
            {
                Id = (long)r.Id,
                Description = (string)r.Description,
                AssignedUser = (string)r.AssignedUser,
                Status = (TaskStatusApp)(long)r.Status,
                Priority = (TaskPriority)(long)r.Priority,
                DueDate = DateOnly.Parse((string)r.DueDateStr),
                Notes = (string?)r.Notes,
                CreatedAtUtc = DateTime.Parse((string)r.CreatedAtUtcStr),
                UpdatedAtUtc = DateTime.Parse((string)r.UpdatedAtUtcStr),
            });
        }

        return list;
    }

    public async Task<TaskItem?> GetByIdAsync(long id, CancellationToken ct)
    {
        using var con = _factory.Create();
        con.Open();

        var row = await con.QueryFirstOrDefaultAsync("""
        SELECT
            id as Id,
            description as Description,
            assigned_user as AssignedUser,
            status as Status,
            priority as Priority,
            due_date as DueDateStr,
            notes as Notes,
            created_at_utc as CreatedAtUtcStr,
            updated_at_utc as UpdatedAtUtcStr
        FROM tasks
        WHERE id = @id
        LIMIT 1;
        """, new { id });

        if (row is null) return null;

        return new TaskItem
        {
            Id = (long)row.Id,
            Description = (string)row.Description,
            AssignedUser = (string)row.AssignedUser,
            Status = (TaskStatusApp)(long)row.Status,
            Priority = (TaskPriority)(long)row.Priority,
            DueDate = DateOnly.Parse((string)row.DueDateStr),
            Notes = (string?)row.Notes,
            CreatedAtUtc = DateTime.Parse((string)row.CreatedAtUtcStr),
            UpdatedAtUtc = DateTime.Parse((string)row.UpdatedAtUtcStr),
        };
    }

    /// <summary>
    /// Esta función se encarga de crear nuevas tareas (Sentencia directa en BD).   
    /// </summary>
    /// <param name="item">Item de la tarea que se va a crear</param>
    /// <param name="ct">Permite cancelar la operación de una manera controlada</param>
    /// <returns>Returna el id de la tarea creada</returns>
    public async Task<long> CreateAsync(TaskItem item, CancellationToken ct)
    {
        using var con = _factory.Create();
        con.Open();

        var id = await con.ExecuteScalarAsync<long>("""
        INSERT INTO tasks(description, assigned_user, status, priority, due_date, notes, created_at_utc, updated_at_utc)
        VALUES(@Description, @AssignedUser, @Status, @Priority, @DueDate, @Notes, @CreatedAtUtc, @UpdatedAtUtc);
        SELECT last_insert_rowid();
        """, new
        {
            item.Description,
            item.AssignedUser,
            Status = (int)item.Status,
            Priority = (int)item.Priority,
            DueDate = item.DueDate.ToString("yyyy-MM-dd"),
            item.Notes,
            CreatedAtUtc = item.CreatedAtUtc.ToString("O"),
            UpdatedAtUtc = item.UpdatedAtUtc.ToString("O"),
        });

        return id;
    }
    /// <summary>
    /// Esta función se encarga de actualizar la tarea seleccionada (Sentencia directa en BD).   
    /// </summary>
    /// <param name="item">Item de la tarea que se va a actualizar</param>
    /// <param name="ct">Permite cancelar la operación de una manera controlada</param>
    public async Task UpdateAsync(TaskItem item, CancellationToken ct)
    {
        using var con = _factory.Create();
        con.Open();

        await con.ExecuteAsync("""
        UPDATE tasks
        SET description=@Description,
            assigned_user=@AssignedUser,
            status=@Status,
            priority=@Priority,
            due_date=@DueDate,
            notes=@Notes,
            updated_at_utc=@UpdatedAtUtc
        WHERE id=@Id;
        """, new
        {
            item.Id,
            item.Description,
            item.AssignedUser,
            Status = (int)item.Status,
            Priority = (int)item.Priority,
            DueDate = item.DueDate.ToString("yyyy-MM-dd"),
            item.Notes,
            UpdatedAtUtc = item.UpdatedAtUtc.ToString("O"),
        });
    }
    /// <summary>
    /// Esta función se encarga de eliminar la tarea seleccionada (Sentencia directa en BD).   
    /// </summary>
    /// <param name="id">Id de la tarea a eliminar</param>
    /// <param name="ct">Permite cancelar la operación de una manera controlada</param>
    public async Task DeleteAsync(long id, CancellationToken ct)
    {
        using var con = _factory.Create();
        con.Open();
        await con.ExecuteAsync("DELETE FROM tasks WHERE id=@id;", new { id });
    }
}