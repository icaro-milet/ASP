using ASP.Application.Dtos;
using ASP.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Api.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [ApiVersion("0.9", Deprecated = true)]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductAppService _productAppService;

        public ProductsController(
            IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }

        [HttpGet]
        [MapToApiVersion("1.0")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _productAppService.GetAllAsync();

            return result.Any() ? Ok(result) : NotFound();
        }

        [HttpGet("{productId}")]
        [MapToApiVersion("1.0")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(IEnumerable<ProductDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetById(Guid productId)
        {
            var result = await _productAppService.GetByIdAsync(productId);

            return Ok(result);
        }

        //[HttpPost]
        //[MapToApiVersion("1.0")]
        //[Produces("application/json")]
        //[ProducesResponseType(StatusCodes.Status201Created)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
        //public async Task<IActionResult> CreateProduct([FromBody] ProductDto productDto)
        //{
        //    var item = await _productAppService.InsertAsync(productDto);

        //    return CreatedAtAction(nameof(GetById), new { productId = item.Id }, item);
        //}

        //[HttpPatch("{productId}")]
        //[MapToApiVersion("1.0")]
        //[Produces("application/json")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
        //public async Task<IActionResult> UpdateProduct(Guid productId, [FromBody] JsonPatchDocument<ProductDto> patchProduct)
        //{
        //    var entity = await _productAppService.GetByIdAsync(productId);

        //    if (entity == null)
        //    {
        //        return NotFound();
        //    }

        //    patchProduct.ApplyTo(entity, ModelState);
        //    var retorno = await _productAppService.PatchAsync(productId, entity);

        //    return Ok(retorno);
        //}

        //[HttpDelete("{productId}")]
        //[Produces("application/json")]
        //[ProducesResponseType(StatusCodes.Status204NoContent)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //public async Task<IActionResult> DeleteAsync(Guid productId)
        //{
        //    var retorno = await _productAppService.DeleteAsync(productId);
        //    return retorno ? NoContent() : BadRequest($"ID Inválido: {productId}");
        //}

        //[HttpPut("{productId}")]
        //[MapToApiVersion("1.0")]
        //[Produces("application/json")]
        //[ProducesResponseType(StatusCodes.Status201Created)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
        //public async Task<IActionResult> UpdateProductAsync(Guid productId, [FromBody] ProductDto productDto)
        //{
        //    var item = await _productAppService.UpdateAsync(productId, productDto);

        //    return item is null ? NotFound() : Ok(item);
        //}
    }
}
