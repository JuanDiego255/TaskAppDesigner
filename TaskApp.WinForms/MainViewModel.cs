using System.ComponentModel;
using TaskApp.Application;
using TaskApp.Domain;

namespace TaskApp.WinForms;

public class MainViewModel
{
    private readonly TaskService _service;

    public BindingList<TaskItem> Items { get; } = new();

    public string? FilterText { get; set; }
    public TaskStatusApp? FilterStatus { get; set; }
    public TaskPriority? FilterPriority { get; set; }
    public string? FilterUser { get; set; }

    public MainViewModel(TaskService service) => _service = service;
    /// <summary>
    /// Permite recargar la tabla de tareas.
    /// </summary>
    public async Task ReloadAsync()
    {
        var list = await _service.ListAsync(
            new TaskQuery(FilterText, FilterStatus, FilterPriority, FilterUser),
            CancellationToken.None);

        Items.RaiseListChangedEvents = false;
        Items.Clear();
        foreach (var x in list) Items.Add(x);
        Items.RaiseListChangedEvents = true;
        Items.ResetBindings();
    }
    public async Task CreateAsync(TaskItem item)
        => await _service.CreateAsync(item, CancellationToken.None);

    public async Task UpdateAsync(TaskItem item)
        => await _service.UpdateAsync(item, CancellationToken.None);

    public async Task DeleteAsync(long id)
        => await _service.DeleteAsync(id, CancellationToken.None);

    public async Task ChangeStatusAsync(long id, TaskStatusApp next)
        => await _service.ChangeStatusAsync(id, next, CancellationToken.None);
}
