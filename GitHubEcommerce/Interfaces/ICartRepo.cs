using GitHubEcommerce.Dtos;
using GitHubEcommerce.Models;

namespace GitHubEcommerce.Interfaces
{
    public interface ICartRepo
    {
        public void AddToCartS(CartItemDto cartItem);
        public List<CartItem> GetCartItems();
        public List<CartItem> GetCartItems(Guid userId);
        public CartItem GetCartItemById(Guid cartitemId);
        public void UpdateCartItem(Guid cartitemId,Guid userId, CartItem cartItem);
        public Guid DeleteCartItem(Guid userId, Guid cartitemId);
        public Guid DeleteCartItems(Guid userId);

    }
}
