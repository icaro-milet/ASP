using ASP.Domain.Aggregates.Products.Entities;
using ASP.Domain.Aggregates.Products.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ASP.Infra.Database.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public readonly AppDbContext _productContext;
        public ProductRepository(AppDbContext productContext)
        {
            _productContext = productContext;
        }

        public Task<Product> AddAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _productContext.Produts.ToListAsync();
        }

        public Task<Product> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> PatchAsync(Guid id, Product product)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<Product> UpdateAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
