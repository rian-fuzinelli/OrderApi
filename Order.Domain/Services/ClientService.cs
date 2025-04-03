using Order.Domain.Interfaces.Repositories;
using Order.Domain.Interfaces.Services;
using Order.Domain.Models;
using Order.Domain.Validations;
using Order.Domain.Validations.Base;

namespace Order.Domain.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<Response> CreateAsync(ClientModel client)
        {
            var validation = new ClientValidation();
            var validationResult = validation.Validate(client);

            if(!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors.Select(x => x.ErrorMessage);
                return new Response(false, "Validation failed");
            }

            var existingClient = await _clientRepository.GetByIdAsync(client.Id);
            if (existingClient != null)
            {
                return new Response(false, $"Client with this {client.Id} already exists");
            }

            await _clientRepository.CreateAsync(client);
            return new Response(true, "Client created successfully");
        }

        public async Task<Response> DeleteAsync(string clientId)
        {
            var client = await _clientRepository.GetByIdAsync(clientId);

            if (client == null)
            {
                return new Response(false, $"Client with the {clientId} not found");
            }

            await _clientRepository.DeleteAsync(clientId);
            return new Response(true, "Client deleted successfully");
        }

        public async Task<Response<ClientModel>> GetByIdAsync(string clientId)
        {
            var client = await _clientRepository.GetByIdAsync(clientId);

            if (client == null)
            {
                return new Response<ClientModel>(false, $"Client with {clientId} not found", client!);
            }
            return new Response<ClientModel>(true, "Client retrieved successfully", client);
        }

        public async Task<Response<List<ClientModel>>> ListByFilterAsync(string clientId, string name)
        {

            var client = await _clientRepository.ListByFilterAsync(clientId, name);
            if (client == null || client.Count == 0)
            {
                return new Response<List<ClientModel>>(false, "No clients found", []);
            }
            return new Response<List<ClientModel>>(true, "Clients retrieved successfully", client);
        }

        public async Task<Response> UpdateAsync(ClientModel client)
        {
            var clientEntity = await _clientRepository.GetByIdAsync(client.Id);

            if (clientEntity == null)
            {
                return new Response(false, $"Client with {client.Id} not found");
            }

            await _clientRepository.UpdateAsync(client);
            return new Response(true, "Client updated successfully");
        }
    }
}
