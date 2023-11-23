using ASP.Domain.Aggregates.Products.Entities;
using ASP.Domain.Aggregates.Products.Interfaces.Repositories;
using ASP.Domain.Aggregates.Products.Interfaces.Services;

namespace ASP.Domain.Aggregates.Products.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(
            IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<Product> AddAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Guid productId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _productRepository.GetAllAsync();
        }

        public Task<Product> GetByIdAsync(Guid productId)
        {
            throw new NotImplementedException();
        }

        public Task<Product> PatchAsync(Guid productId, Product product)
        {
            throw new NotImplementedException();
        }

        public Task<Product> UpdateAsync(Guid productId, Product product)
        {
            throw new NotImplementedException();
        }
    }
}
