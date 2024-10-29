using AutoMapper;
using EntityTask.DATA.Entity;
using EntityTask.DTO;

namespace EntityTask.Mapper
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Category, CategoryByIdDTO>().ReverseMap();
            CreateMap<Category, UpdateCategoryDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();

            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Product, ProductByIdDTO>().ReverseMap();
            CreateMap<Product, UpdateProductDTO>().ReverseMap();
        }
    }
}
