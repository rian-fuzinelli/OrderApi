using Order.Domain.Interfaces.Repositories;
using Order.Domain.Interfaces.Services;
using Order.Domain.Models;

namespace Order.Domain.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public Task CreateAsync(ClientModel client)
        {
            _clientRepository.CreateAsync(client);
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string clientId)
        {
            throw new NotImplementedException();
        }

        public Task<ClientModel> GetByIdAsync(string clientId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ClientModel>> ListByFilterAsync(string? clientId = null, string? name = null)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ClientModel client)
        {
            throw new NotImplementedException();
        }
    }
}
