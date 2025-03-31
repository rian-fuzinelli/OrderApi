using Order.Domain.Interfaces.Services;
using Order.Domain.Models;

namespace Order.Domain.Services
{
    public class UserService : IUserService
    {
        public Task<bool> AuthenticationAsync(UserModel user)
        {
            throw new NotImplementedException();
        }

        public Task CreateAsync(UserModel user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<ClientModel> GetByIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ClientModel>> ListByFilterAsync(string? userId = null, string? name = null)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(UserModel user)
        {
            throw new NotImplementedException();
        }
    }
}
