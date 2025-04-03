namespace Order.Application.DTOs.Request
{
    public class CreateClientRequestDto
    {
        public string? Name { get; set; }

        public string? Email { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Address { get; set; }    
    }
}
