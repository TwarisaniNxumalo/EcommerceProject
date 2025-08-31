using GitHubEcommerce.Dtos;
using GitHubEcommerce.Models;

namespace GitHubEcommerce.Interfaces
{
    public interface IOrderRepo
    {
        public void AddOrder(OrderDto order);
        public List<Order> GetOrders();
        public List<Order> GetOrders(Guid userId);
        public Order GetOrderById(Guid orderId);
        public Order GetOrderById(Guid orderId,Guid userId);
        public void UpdateOrder(Guid orderId, OrderDto order);
        public Guid DeleteOrder(Guid orderId);
    }
}
