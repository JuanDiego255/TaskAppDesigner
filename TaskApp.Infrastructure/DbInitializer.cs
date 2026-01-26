using Dapper;

namespace TaskApp.Infrastructure;

public class DbInitializer
{
    private readonly SqliteConnectionFactory _factory;
    public DbInitializer(SqliteConnectionFactory factory) => _factory = factory;
    /// <summary>
    /// Crea la tabla de tareas, además valida si existen registros para evitar iniciar con la tabla vacía
    /// </summary>
    public void EnsureCreated()
    {
        using var con = _factory.Create();
        con.Open();

        con.Execute("""
        CREATE TABLE IF NOT EXISTS tasks (
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            description TEXT NOT NULL,
            assigned_user TEXT NOT NULL,
            status INTEGER NOT NULL,
            priority INTEGER NOT NULL,
            due_date TEXT NOT NULL,
            notes TEXT NULL,
            created_at_utc TEXT NOT NULL,
            updated_at_utc TEXT NOT NULL
        );

        CREATE INDEX IF NOT EXISTS idx_tasks_due_date ON tasks(due_date);
        CREATE INDEX IF NOT EXISTS idx_tasks_status ON tasks(status);
        """);

        var count = con.ExecuteScalar<long>("SELECT COUNT(1) FROM tasks;");
        if (count == 0)
        {
            con.Execute("""
            INSERT INTO tasks(description, assigned_user, status, priority, due_date, notes, created_at_utc, updated_at_utc)
            VALUES
            ('Crear APP prueba tecnica', 'Juan Astorga', 0, 2, '2026-01-29', 'Primer registro', @now, @now);
            """, new { now = DateTime.UtcNow.ToString("O") });
        }
    }
}