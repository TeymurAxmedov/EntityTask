using EntityTask.DATA.Entity;
using EntityTask.DATA;
using EntityTask.DTO;
using EntityTask.Model.Repository.Interfaces;
using System.Threading.Tasks;

namespace EntityTask.Model.Repository.Impl
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;
        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task Create(Category category)
        {
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(CategoryDTO category)
        {
            var categoryDelete = await _context.Categories.FindAsync(category.Id);
            if (categoryDelete != null)
            {
                _context.Categories.Remove(categoryDelete);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Category> GetCategoryById(int id)
        {
            var CategoryEntity = await _context.Categories.FindAsync(id);
            return CategoryEntity;


        }

        public async Task<int> Submit()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task UpdateCategory(Category category)
        {
            _context.Categories.Update(category);
        }

    }
}
