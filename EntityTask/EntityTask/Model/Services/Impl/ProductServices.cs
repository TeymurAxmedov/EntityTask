using AutoMapper;
using EntityTask.DATA.Entity;
using EntityTask.DTO;
using EntityTask.Model.Repository.Impl;
using EntityTask.Model.Repository.Interfaces;
using EntityTask.Model.Services.Interfaces;
using System.Threading.Tasks;

namespace EntityTask.Model.Services.Impl
{
    public class ProductServices : IProductServices
    {
        private readonly IMapper mapper;
        private readonly IProductRepository productRepository;

        public ProductServices(IMapper mapper, IProductRepository productRepository)
        {
            this.mapper = mapper;
            this.productRepository = productRepository;

        }

        public async Task Create(ProductDTO productDTO)
        {
            var ProductEntity = mapper.Map<Product>(productDTO);
            await productRepository.Create(ProductEntity);

            await productRepository.Submit();
        }

        public async Task DeleteProduct(ProductDTO product)
        {
            await productRepository.DeleteAsync(product);
        }

        public async Task<ProductByIdDTO> GetProductById(int id)
        {
            var ProductEntity = await productRepository.GetProductById(id);
            var productDTO = mapper.Map<ProductByIdDTO>(ProductEntity);
            return productDTO;
        }

        public async Task UpdateProduct(UpdateProductDTO product)
        {
            var resultEntity = mapper.Map<Product>(product);

            await productRepository.UpdateProduct(resultEntity);
        }

    }
}
