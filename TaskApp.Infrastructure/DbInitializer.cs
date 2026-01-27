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

        // Habilitar llaves foráneas en SQLite
        con.Execute("PRAGMA foreign_keys = ON;");

        con.Execute("""
            CREATE TABLE IF NOT EXISTS users (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                name TEXT NOT NULL,
                description TEXT NOT NULL,
                created_at_utc TEXT NOT NULL,
                updated_at_utc TEXT NOT NULL
            );
            """);

        con.Execute("""
            CREATE TABLE IF NOT EXISTS tasks (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                description TEXT NOT NULL,
                assigned_user_id INTEGER NOT NULL,
                status INTEGER NOT NULL,
                priority INTEGER NOT NULL,
                due_date TEXT NOT NULL,
                notes TEXT NULL,
                created_at_utc TEXT NOT NULL,
                updated_at_utc TEXT NOT NULL,
                CONSTRAINT fk_tasks_users
                    FOREIGN KEY (assigned_user_id)
                    REFERENCES users(id)
                    ON UPDATE CASCADE
                    ON DELETE RESTRICT
            );

            CREATE INDEX IF NOT EXISTS idx_tasks_due_date ON tasks(due_date);
            CREATE INDEX IF NOT EXISTS idx_tasks_status ON tasks(status);
            CREATE INDEX IF NOT EXISTS idx_tasks_assigned_user ON tasks(assigned_user_id);
            """);

        var count = con.ExecuteScalar<long>("SELECT COUNT(1) FROM tasks;");
        if (count == 0)
        {
            var now = DateTime.UtcNow.ToString("O");
            con.Execute("""
                INSERT INTO users(name, description, created_at_utc, updated_at_utc)
                SELECT 'Juan Astorga', 'Usuario inicial', @now, @now
                WHERE NOT EXISTS (
                    SELECT 1 FROM users WHERE name = 'Juan Astorga'
                );
                """, new { now });

            con.Execute("""
                INSERT INTO users(name, description, created_at_utc, updated_at_utc)
                SELECT 'Juan Tester', 'Usuario Tester', @now, @now
                WHERE NOT EXISTS (
                    SELECT 1 FROM users WHERE name = 'Juan Tester'
                );
                """, new { now });

            var userId = con.ExecuteScalar<long>("""
                SELECT id FROM users WHERE name = 'Juan Astorga';
            """);
            
            con.Execute("""
                INSERT INTO tasks(
                    description,
                    assigned_user_id,
                    status,
                    priority,
                    due_date,
                    notes,
                    created_at_utc,
                    updated_at_utc
                )
                VALUES (
                    'Crear APP prueba tecnica',
                    @userId,
                    0,
                    2,
                    '2026-01-29',
                    'Primer registro',
                    @now,
                    @now
                );
                """, new { userId, now });
        }
    }
}