using System.ComponentModel;
using TaskApp.Application;
using TaskApp.Domain;

namespace TaskApp.WinForms;

public class UserViewModel
{
    private readonly UserService _service;

    public BindingList<UserItem> Items { get; } = new();

    public string? FilterUser { get; set; }

    public UserViewModel(UserService service) => _service = service;
    /// <summary>
    /// Permite recargar la tabla de tareas.
    /// </summary>
    public async Task ReloadAsyncUser()
    {
        var list = await _service.ListAsync(
            new UserQuery(FilterUser),
            CancellationToken.None);

        Items.RaiseListChangedEvents = false;
        Items.Clear();
        foreach (var x in list) Items.Add(x);
        Items.RaiseListChangedEvents = true;
        Items.ResetBindings();
    }

    public async Task GetListComboBox()
    {
        var list = await _service.ListAsync(
            new UserQuery(null),
            CancellationToken.None);

        Items.RaiseListChangedEvents = false;
        Items.Clear();
        foreach (var x in list) Items.Add(x);
        Items.RaiseListChangedEvents = true;
        Items.ResetBindings();
    }
    public async Task CreateAsync(UserItem item)
        => await _service.CreateAsync(item, CancellationToken.None);
    public async Task UpdateAsync(UserItem item)
        => await _service.UpdateAsync(item, CancellationToken.None);
    public async Task DeleteAsync(long id)
        => await _service.DeleteAsync(id, CancellationToken.None);
}
