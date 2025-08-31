using GitHubEcommerce.Dtos;
using GitHubEcommerce.Models;

namespace GitHubEcommerce.Interfaces
{
    public interface IProductRepo
    {
        public void AddProduct(ProductDto product);
        public ICollection<Product> GetProducts();
        public Product GetProductById(Guid productId);
        public void UpdateProduct(Guid productId, ProductDto product);
        public Guid DeleteProduct(Guid productId);

    }
}
