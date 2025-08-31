namespace GitHubEcommerce.Models
{
    public class Category
    {
        public Guid categoryId {  get; set; }
        public required string name { get; set; }
        public required string description { get; set; }

    }
}
