using EntityTask.DATA.Entity;
using EntityTask.DTO;
using System.Threading.Tasks;

namespace EntityTask.Model.Repository.Interfaces
{
    public interface IProductRepository
    {
        Task Create(Product product);
        Task DeleteAsync(ProductDTO product);
        Task<Product> GetProductById(int id);
        Task <int>Submit();
        Task UpdateProduct(Product id);
    }
}
