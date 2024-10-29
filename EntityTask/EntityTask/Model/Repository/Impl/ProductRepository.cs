using EntityTask.DATA;
using EntityTask.DATA.Entity;
using EntityTask.DTO;
using EntityTask.Model.Repository.Interfaces;
using System.Threading.Tasks;

namespace EntityTask.Model.Repository.Impl
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;
        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task Create(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async  Task DeleteAsync(ProductDTO product)
        {
           
                var productDelete = await _context.Products.FindAsync(product.id);
                if (productDelete != null)
                {
                    _context.Products.Remove(productDelete);
                    await _context.SaveChangesAsync();
                }
            
        }

        public async  Task<Product> GetProductById(int id)
        {
            var ProductEntity = await _context.Products.FindAsync(id);
            return ProductEntity;
        }

        public async Task<int> Submit()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task UpdateProduct(Product product)
        {
            _context.Products.Update(product);
        }
    }
}
