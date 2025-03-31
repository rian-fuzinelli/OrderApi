using Order.Domain.Models;

namespace Order.Domain.Interfaces.Services
{
    public interface IUserService
    {
        Task<bool> AuthenticationAsync(UserModel user);
        Task CreateAsync(UserModel user);

        Task UpdateAsync(UserModel user);

        Task DeleteAsync(string userId);

        Task<ClientModel> GetByIdAsync(string userId);

        Task<List<ClientModel>> ListByFilterAsync(string? userId = null, string? name = null);
    }
}
