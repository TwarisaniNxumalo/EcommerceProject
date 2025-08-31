namespace GitHubEcommerce.Models
{
    public class CartItem
    {
        public Guid cartitemId {  get; set; }
        public required int quantity { get; set; }
        public required DateTime addedat { get; set; }
        public required User user { get; set; }
        public required Product product { get; set; }

    }
}
