using EntityTask.DATA.Entity;
using EntityTask.DTO;
using System.Threading.Tasks;

namespace EntityTask.Model.Repository.Interfaces
{
    public interface ICategoryRepository
    {
        Task Create(Category category);

        Task DeleteAsync(CategoryDTO category);
        Task<Category> GetCategoryById(int id);
        Task<int> Submit();
        Task UpdateCategory(Category id);
    }
}
