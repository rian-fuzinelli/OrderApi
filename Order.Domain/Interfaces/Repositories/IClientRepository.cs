﻿using Order.Domain.Models;

namespace Order.Domain.Interfaces.Repositories
{
    public interface IClientRepository
    {
        Task CreateAsync(ClientModel client);

        Task UpdateAsync(ClientModel client);

        Task AddAsync(ClientModel client);

        Task DeleteAsync(string clientId);

        Task<bool> ExistsByIdAsync(string clientId);

        Task<ClientModel> GetByIdAsync(string clientId);

        Task<List<ClientModel>> ListByFilterAsync(string clientId, string? name);
    }
}
