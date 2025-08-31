namespace GitHubEcommerce.Dtos
{
    public class CategoryDto
    {
        public Guid categoryId {  get; set; }
        public required string name { get; set; }
        public required string description { get; set; }

    }
}
