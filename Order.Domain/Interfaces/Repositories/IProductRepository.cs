using Order.Domain.Models;

namespace Order.Domain.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task CreateAsync(ProductModel product);

        Task UpdateAsync(ProductModel product);

        Task DeleteAsync(string productId);

        Task<bool> ExistsByIdAsync(string productId);

        Task<ProductModel> GetByIdAsync(string product);

        Task<List<ProductModel>> ListByFilterAsync(string productId = null, string description = null);
    }
}
