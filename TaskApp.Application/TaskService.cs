using TaskApp.Domain;

namespace TaskApp.Application;

public class TaskService
{
    private readonly ITaskRepository _repo;

    public TaskService(ITaskRepository repo) => _repo = repo;

    public Task<IReadOnlyList<TaskItem>> ListAsync(TaskQuery q, CancellationToken ct)
        => _repo.GetAsync(q, ct);
    /// <summary>
    /// Esta función se encarga de crear nuevas tareas.   
    /// </summary>
    /// <param name="item">Item de la tarea que se va a crear</param>
    /// <param name="ct">Permite cancelar la operación de una manera controlada</param>
    /// <returns>Returna el id de la tarea creada</returns>
    public async Task<long> CreateAsync(TaskItem item, CancellationToken ct)
    {
        item.Status = TaskStatusApp.Pending;
        item.CreatedAtUtc = DateTime.UtcNow;
        item.UpdatedAtUtc = item.CreatedAtUtc;
        return await _repo.CreateAsync(item, ct);
    }
    /// <summary>
    /// Esta función se encarga de actualizar la tarea seleccionada.   
    /// </summary>
    /// <param name="item">Item de la tarea que se va a actualizar</param>
    /// <param name="ct">Permite cancelar la operación de una manera controlada</param>
    public async Task UpdateAsync(TaskItem item, CancellationToken ct)
    {
        var current = await _repo.GetByIdAsync(item.Id, ct)
            ?? throw new InvalidOperationException("Tarea no existe.");

        if (current.Status != TaskStatusApp.Pending)
            throw new InvalidOperationException("Solo se puede editar en estado Pendiente.");

        item.Status = current.Status;
        item.CreatedAtUtc = current.CreatedAtUtc;
        item.UpdatedAtUtc = DateTime.UtcNow;

        await _repo.UpdateAsync(item, ct);
    }
    /// <summary>
    /// Esta función se encarga de eliminar la tarea seleccionada.   
    /// </summary>
    /// <param name="id">Id de la tarea a eliminar</param>
    /// <param name="ct">Permite cancelar la operación de una manera controlada</param>
    public async Task DeleteAsync(long id, CancellationToken ct)
    {
        var current = await _repo.GetByIdAsync(id, ct)
            ?? throw new InvalidOperationException("Tarea no existe.");

        if (current.Status == TaskStatusApp.InProgress)
            throw new InvalidOperationException("No se puede eliminar si está En Proceso.");

        await _repo.DeleteAsync(id, ct);
    }
    /// <summary>
    /// Esta función se encarga de actualizar el estado la tarea seleccionada.   
    /// </summary>
    /// <param name="id">Id de la tarea a actualizar</param>
    /// <param name="next">Estado a establecer</param>
    /// <param name="ct">Permite cancelar la operación de una manera controlada</param>
    public async Task ChangeStatusAsync(long id, TaskStatusApp next, CancellationToken ct)
    {
        var current = await _repo.GetByIdAsync(id, ct)
            ?? throw new InvalidOperationException("Tarea no existe.");
        //Flujo permitido para que se cumpla la actualizaciín de estado
        var allowed = (current.Status, next) switch
        {
            (TaskStatusApp.Pending, TaskStatusApp.InProgress) => true,
            (TaskStatusApp.InProgress, TaskStatusApp.Done) => true,
            _ => false
        };

        if (!allowed) throw new InvalidOperationException("Transición de estado no permitida.");

        current.Status = next;
        current.UpdatedAtUtc = DateTime.UtcNow;
        await _repo.UpdateAsync(current, ct);
    }
}