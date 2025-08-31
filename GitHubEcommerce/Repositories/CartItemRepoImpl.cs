using GitHubEcommerce.Dtos;
using GitHubEcommerce.Interfaces;
using GitHubEcommerce.Models;

namespace GitHubEcommerce.Repositories
{
    public class CartItemRepoImpl : ICartRepo
    {
        public void AddToCartS(CartItemDto cartItem)
        {
            throw new NotImplementedException();
        }

        public Guid DeleteCartItem(Guid userId, Guid cartitemId)
        {
            throw new NotImplementedException();
        }

        public Guid DeleteCartItems(Guid userId)
        {
            throw new NotImplementedException();
        }

        public CartItem GetCartItemById(Guid cartitemId)
        {
            throw new NotImplementedException();
        }

        public List<CartItem> GetCartItems()
        {
            throw new NotImplementedException();
        }

        public List<CartItem> GetCartItems(Guid userId)
        {
            throw new NotImplementedException();
        }

        public void UpdateCartItem(Guid cartitemId, Guid userId, CartItem cartItem)
        {
            throw new NotImplementedException();
        }
    }
}
