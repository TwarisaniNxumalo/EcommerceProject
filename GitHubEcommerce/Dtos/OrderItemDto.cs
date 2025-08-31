namespace GitHubEcommerce.Dtos
{
    public class OrderItemDto
    {
        public Guid orderitemId { get; set; }
        public required int quantity { get; set; }
        public required decimal unitprice { get; set; }
        public required OrderDto order { get; set; }
        public required ProductDto product { get; set; }
    }
}
