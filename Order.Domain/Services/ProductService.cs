using Order.Domain.Interfaces.Services;
using Order.Domain.Models;

namespace Order.Domain.Services
{
    public class ProductService : IProductService
    {
        public Task CreateAsync(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string productId)
        {
            throw new NotImplementedException();
        }

        public Task<ProductModel> GetByIdAsync(string product)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductModel>> ListByFilterAsync(string? productId = null, string? description = null)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ProductModel product)
        {
            throw new NotImplementedException();
        }
    }
}
