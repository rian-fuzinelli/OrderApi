using Order.Domain.Models;

namespace Order.Domain.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task CreateAsync(UserModel user);

        Task UpdateAsync(UserModel user);

        Task DeleteAsync(string userId);

        Task<ClientModel> GetByIdAsync(string userId);

        Task<List<ClientModel>> ListByFilterAsync(string userId = null, string name = null);

        Task<bool> ExistsByIdAsync(string userId);

        Task<bool> ExistsByLoginAsync(string login);
    }
}
