using System.Security.Cryptography;
using GitHubEcommerce.Dtos;
using GitHubEcommerce.Interfaces;
using GitHubEcommerce.Models;

namespace GitHubEcommerce.Repositories
{
    public class ProductRepoImpl : IProductRepo
    {
        public void AddProduct(ProductDto product)
        {
            throw new NotImplementedException();
        }

        public Guid DeleteProduct(Guid productId)
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(Guid productId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Product> GetProducts()
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Guid productId, ProductDto product)
        {
            throw new NotImplementedException();
        }
    }
}
