using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskApp.Domain;

namespace TaskApp.Application;
public record UserQuery(
    string? Name = null
);
public interface IUserRepository
{
    Task<IReadOnlyList<UserItem>> GetAsync(UserQuery query, CancellationToken ct);
    Task<UserItem?> GetByIdAsync(long id, CancellationToken ct);
    Task<long> CreateAsync(UserItem item, CancellationToken ct);
    Task UpdateAsync(UserItem item, CancellationToken ct);
    Task DeleteAsync(long id, CancellationToken ct);
}
