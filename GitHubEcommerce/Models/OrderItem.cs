namespace GitHubEcommerce.Models
{
    public class OrderItem
    {
        public Guid orderitemId { get; set; }
        public required int quantity { get; set; }
        public required decimal unitprice { get; set; }
        public required Order order { get; set; }
        public required Product product { get; set; }
    }
}
