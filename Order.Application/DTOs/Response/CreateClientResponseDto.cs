using Order.Application.DTOs.Request;

namespace Order.Application.DTOs.Response
{
    public class CreateClientResponseDto : CreateClientRequestDto
    {
        public long Id { get; set; }
    }
}
