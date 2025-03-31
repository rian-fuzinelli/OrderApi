using Order.Domain.Models;

namespace Order.Domain.Interfaces.Services
{
    public interface IOrderService
    {
        Task CreateAsync(OrderModel order);

        Task UpdateAsync(OrderModel order);

        Task DeleteAsync(string orderId);

        Task<OrderModel> GetByIdAsync(string orderId);

        Task<List<OrderModel>> ListByFilterAsync(string? orderId = null, string? clientId = null, string? userId = null);

    }
}
