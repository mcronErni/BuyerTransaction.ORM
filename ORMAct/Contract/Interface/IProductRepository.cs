using ORMAct.Model;

namespace ORMAct.Contract.Interface
{
    public interface IProductRepository
    {
        public Task<ICollection<Product>> Get();
        public Task<Product?> GetProductById(int id);
        public Task<Product?> CreateProduct(Product product);
        public Task<Product?> UpdateProduct(int id, Product product);
        public Task<Product?> DeleteProduct(int id);
    }
}
