namespace Order.Domain.Models
{
    public abstract class EntityBase
    {
        public string Id { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
