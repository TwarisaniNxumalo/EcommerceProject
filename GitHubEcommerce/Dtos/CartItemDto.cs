namespace GitHubEcommerce.Dtos
{

    public class CartItemDto
    {
        public Guid cartitemId { get; set; }
        public required int quantity { get; set; }
        public required DateTime addedat { get; set; }
        public required UserDto user { get; set; }
        public required ProductDto product { get; set; }

    }
}
