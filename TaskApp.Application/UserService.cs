using TaskApp.Domain;

namespace TaskApp.Application;

public class UserService
{
    private readonly IUserRepository _repo;

    public UserService(IUserRepository repo) => _repo = repo;

    public Task<IReadOnlyList<UserItem>> ListAsync(UserQuery q, CancellationToken ct)
        => _repo.GetAsync(q, ct);
    /// <summary>
    /// Esta función se encarga de crear nuevos usuarios.   
    /// </summary>
    /// <param name="item">Item del usuario que se va a crear</param>
    /// <param name="ct">Permite cancelar la operación de una manera controlada</param>
    /// <returns>Returna el id del usuario creado</returns>
    public async Task<long> CreateAsync(UserItem item, CancellationToken ct)
    {
        item.CreatedAtUtc = DateTime.UtcNow;
        item.UpdatedAtUtc = item.CreatedAtUtc;
        return await _repo.CreateAsync(item, ct);
    }
    /// <summary>
    /// Esta función se encarga de actualizar el usuario seleccionado.   
    /// </summary>
    /// <param name="item">Item del usuario que se va a actualizar</param>
    /// <param name="ct">Permite cancelar la operación de una manera controlada</param>
    public async Task UpdateAsync(UserItem item, CancellationToken ct)
    {
        var current = await _repo.GetByIdAsync(item.Id, ct)
            ?? throw new InvalidOperationException("El usuario no existe.");

        item.CreatedAtUtc = current.CreatedAtUtc;
        item.UpdatedAtUtc = DateTime.UtcNow;

        await _repo.UpdateAsync(item, ct);
    }
    /// <summary>
    /// Esta función se encarga de eliminar el usuario seleccionado.   
    /// </summary>
    /// <param name="id">Id del usuario a eliminar</param>
    /// <param name="ct">Permite cancelar la operación de una manera controlada</param>
    public async Task DeleteAsync(long id, CancellationToken ct)
    {
        var current = await _repo.GetByIdAsync(id, ct)
            ?? throw new InvalidOperationException("El usuario no existe.");

        await _repo.DeleteAsync(id, ct);
    }    
}