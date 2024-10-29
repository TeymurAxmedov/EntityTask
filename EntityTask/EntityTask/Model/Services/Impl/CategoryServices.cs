using AutoMapper;
using EntityTask.DATA.Entity;
using EntityTask.DTO;
using EntityTask.Model.Repository.Interfaces;
using EntityTask.Model.Services.Interfaces;
using System.Threading.Tasks;

namespace EntityTask.Model.Services.Impl
{
    public class CategoryService : ICategoryService
    {
        private readonly IMapper mapper;
        private readonly ICategoryRepository categoryRepository;
        public CategoryService(IMapper mapper, ICategoryRepository categoryRepository)
        {
            this.mapper = mapper;
            this.categoryRepository = categoryRepository;
        }

        public async Task Create(CategoryDTO categoryDTO)
        {
            var CategoryEntity = mapper.Map<Category>(categoryDTO);
            await categoryRepository.Create(CategoryEntity);

            await categoryRepository.Submit();
        }

        public async Task<CategoryByIdDTO> GetCategoryById(int id)
        {
            var CategoryEntity = await categoryRepository.GetCategoryById(id);
            var categoryDTO = mapper.Map<CategoryByIdDTO>(CategoryEntity);
            return categoryDTO;
        }

        public async Task UpdateCategory(UpdateCategoryDTO category)
        {
            var resultEntity = mapper.Map<Category>(category);

            await categoryRepository.UpdateCategory(resultEntity);
        }
        public async Task DeleteCategory(CategoryDTO category)
        {
           await categoryRepository.DeleteAsync(category);
        }

       
    }
}
