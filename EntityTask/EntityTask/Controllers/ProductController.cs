using EntityTask.DTO;
using EntityTask.Model.Services.Impl;
using EntityTask.Model.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EntityTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductServices productServices;

        public ProductController(IProductServices productServices)
        {
            this.productServices = productServices;
        }

        [HttpPost]

        public async Task<IActionResult> Create (ProductDTO productDTO)
        {
            await productServices.Create(productDTO);
            return Ok();
        }

        [HttpGet]

        public async Task<IActionResult> GetProductById(int id)
        {
            var result = await productServices.GetProductById(id);
            return Ok(result);
        }

        [HttpPut]

        public async Task<IActionResult> UpdateProduct(UpdateProductDTO updateProductDTO)
        {
            await productServices.UpdateProduct(updateProductDTO);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(ProductDTO product)
        {
            await productServices.DeleteProduct(product);
            return Ok();
        }
    }
}
