namespace GitHubEcommerce.Dtos
{
    public class ProductDto
    {
        public required string name { get; set; }
        public required string imageUrl { get; set; }
        public required string description { get; set; }   
        public required decimal price { get; set; }
        public required int stockquantity {  get; set; }
        public required DateTime createdat {  get; set; }
        public required DateTime updatedat { get; set; } 
        public required CategoryDto category { get; set; }
    }
}
