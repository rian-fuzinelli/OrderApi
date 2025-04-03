using Order.Application.DTOs.Request;
using Order.Application.DTOs.Response;

namespace Order.Application.Interfaces
{
    public interface IClientService  
    {
        IEnumerable<CreateClientResponseDto> GetAllClients();
        CreateClientResponseDto GetClientById(long id);
        CreateClientResponseDto CreateClient(CreateClientRequestDto request);
        CreateClientResponseDto UpdateClient(long id, CreateClientRequestDto request);
    }
}
