using Order.Domain.Models;

namespace Order.Domain.Interfaces.Services
{
    public interface IProductService
    {
        Task CreateAsync(ProductModel product);

        Task UpdateAsync(ProductModel product);

        Task DeleteAsync(string productId);

        Task<ProductModel> GetByIdAsync(string product);

        Task<List<ProductModel>> ListByFilterAsync(string? productId, string? description);
    }
}
