using TaskApp.Domain;

namespace TaskApp.Application;

public record TaskQuery(
    string? Text = null,
    TaskStatusApp? Status = null,
    TaskPriority? Priority = null,
    string? AssignedUser = null
);
/// <summary>
/// Medio para la persistencia y consulta de tareas.
/// Oculta el mecanismo de almacenamiento.
/// </summary>
public interface ITaskRepository
{
    Task<IReadOnlyList<TaskItem>> GetAsync(TaskQuery query, CancellationToken ct);
    Task<TaskItem?> GetByIdAsync(long id, CancellationToken ct);
    Task<long> CreateAsync(TaskItem item, CancellationToken ct);
    Task UpdateAsync(TaskItem item, CancellationToken ct);
    Task DeleteAsync(long id, CancellationToken ct);
}