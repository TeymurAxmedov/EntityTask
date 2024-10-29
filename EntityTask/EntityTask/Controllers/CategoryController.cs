using EntityTask.DTO;
using EntityTask.Model.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EntityTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryDTO categoryDTO)
        {
            await categoryService.Create(categoryDTO);
            return Ok();
        }

        [HttpGet]

        public async Task<IActionResult> GetCategoryById(int id)
        {
            var result = await categoryService.GetCategoryById(id);
            return Ok(result);
        }

        [HttpPut]

        public async Task<IActionResult> UpdateCategory(UpdateCategoryDTO updateCategoryDTO)
        {
            await categoryService.UpdateCategory(updateCategoryDTO);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(CategoryDTO category)
        {
            await categoryService.DeleteCategory(category);
            return Ok();
        }
    }
}
