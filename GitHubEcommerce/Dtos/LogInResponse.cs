namespace GitHubEcommerce.Dtos
{
    public class LogInResponse
    {
        public Guid userId { get; set; }
        public required  string email { get; set; }
        public required  string fullname { get; set; }
        public required string refreshtoken { get; set; }
        public required string accesstoken { get; set;}

    }
}
