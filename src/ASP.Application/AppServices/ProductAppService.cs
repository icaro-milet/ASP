using ASP.Application.Dtos;
using ASP.Application.Factories.Products;
using ASP.Application.Interfaces.Services;
using ASP.Domain.Aggregates.Products.Interfaces.Services;

namespace ASP.Application.AppServices
{
    public class ProductAppService : IProductAppService
    {
        private readonly IProductService _productService;

        public ProductAppService(
            IProductService productService)
        {
            _productService = productService;
        }

        public Task<ProductDto> GetByIdAsync(Guid productId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductDto>> GetAllAsync()
        {
            var result = _productService.GetAllAsync().Result.ToList();

            var products = ProductFactory.ProductsToProductDtos(result);

            return products;
        }   

        public Task<bool> DeleteAsync(Guid productId)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDto> InsertAsync(ProductDto product)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDto> PatchAsync(Guid id, ProductDto productDto)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDto> UpdateAsync(Guid productId, ProductDto product)
        {
            throw new NotImplementedException();
        }
    }
}
