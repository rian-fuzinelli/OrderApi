using Order.Domain.Models;

namespace Order.Domain.Interfaces.Repositories
{
    public interface IOrderRepository
    {
        Task CreateAsync(OrderModel order);

        Task CreateItemAsync(OrderItemModel orderItem);

        Task UpdateAsync(OrderModel order);

        Task UpdateItemAsync(OrderItemModel orderItem);

        Task<bool> ExistsByIdAsync(string orderId);

        Task DeleteAsync(string orderId);

        Task DeleteItemAsync(string orderId);

        Task<OrderModel> GetByIdAsync(string orderId);

        Task<List<OrderModel>> ListByFilterAsync(string orderId = null, string clientId = null, string userId = null);

        Task<List<OrderItemModel>> ListItemByOrderIdAsync(string orderId);

    }
}
