using Order.Application.DTOs.Request;
using Order.Application.DTOs.Response;
using Order.Application.Interfaces;

namespace Order.Application.Services
{
    public class ClientService : IClientService
    {
        public CreateClientResponseDto CreateClient(CreateClientRequestDto request)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CreateClientResponseDto> GetAllClients()
        {
            throw new NotImplementedException();
        }

        public CreateClientResponseDto GetClientById(long id)
        {
            throw new NotImplementedException();
        }

        public CreateClientResponseDto UpdateClient(long id, CreateClientRequestDto request)
        {
            throw new NotImplementedException();
        }
    }
}
