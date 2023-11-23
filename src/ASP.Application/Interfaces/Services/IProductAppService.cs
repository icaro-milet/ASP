using ASP.Application.Dtos;

namespace ASP.Application.Interfaces.Services
{
    public interface IProductAppService
    {
        Task<ProductDto> InsertAsync(ProductDto product);

        Task<IEnumerable<ProductDto>> GetAllAsync();

        Task<ProductDto> GetByIdAsync(Guid productId);

        Task<ProductDto> PatchAsync(Guid id, ProductDto productDto);

        Task<bool> DeleteAsync(Guid productId);

        Task<ProductDto> UpdateAsync(Guid productId, ProductDto product);
    }
}
