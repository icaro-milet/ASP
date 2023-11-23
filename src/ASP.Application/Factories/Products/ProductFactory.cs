using ASP.Application.Dtos;
using ASP.Domain.Aggregates.Products.Entities;

namespace ASP.Application.Factories.Products
{
    public static class ProductFactory
    {
        public static List<Product> ProductDtosToProducts(List<ProductDto> productDtos)
        {
            var products = new List<Product>();

            foreach (var productDto in productDtos)
            {
                var product = new Product()
                {
                    Id = productDto.Id,
                    Category = new Category()
                    {
                        Id = productDto.Category.Id,
                        Description = productDto.Description,
                        Status = productDto.Status
                    },
                    Description = productDto.Description,
                    Dimensions = productDto.Dimensions,
                    Reference = productDto.Reference,
                    Price = productDto.Price,
                    Status = productDto.Status,
                    ProductCode = productDto.ProductCode,
                    Stock = productDto.Stock
                };

                products.Add(product);
            }

            return products;
        }

        public static List<ProductDto> ProductsToProductDtos(List<Product> products)
        {
            var productDtos = new List<ProductDto>();

            foreach (var product in products)
            {
                var productDto = new ProductDto()
                {
                    Id = product.Id,
                    Category = new CategoryDto()
                    {
                        Id = product.Category.Id,
                        Description = product.Description,
                        Status = product.Status
                    },
                    Description = product.Description,
                    Dimensions = product.Dimensions,
                    Reference = product.Reference,
                    Price = product.Price,
                    Status = product.Status,
                    ProductCode = product.ProductCode,
                    Stock = product.Stock
                };

                productDtos.Add(productDto);
            }

            return productDtos;
        }
    }
}
