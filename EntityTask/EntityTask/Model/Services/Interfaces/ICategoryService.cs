using EntityTask.DTO;
using System.Threading.Tasks;

namespace EntityTask.Model.Services.Interfaces
{
    public interface ICategoryService
    {
        public Task<CategoryByIdDTO> GetCategoryById(int id);


        public Task Create(CategoryDTO categoryDTO);
        public Task UpdateCategory(UpdateCategoryDTO category);
        public Task DeleteCategory(CategoryDTO categoryDTO);
    }
}
