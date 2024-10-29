using EntityTask.DTO;
using System.Threading.Tasks;

namespace EntityTask.Model.Services.Interfaces
{
    public interface IProductServices
    {
        public Task Create(ProductDTO productDTO);
        Task DeleteProduct(ProductDTO product);
        public Task<ProductByIdDTO> GetProductById(int id);
        Task UpdateProduct(UpdateProductDTO product);
    }
}
