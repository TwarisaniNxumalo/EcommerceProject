using GitHubEcommerce.Enums;
using Microsoft.EntityFrameworkCore;

namespace GitHubEcommerce.Dtos
{
    public class UserDto
    {
     
        public required string email { get; set; }
        public required string salt { get; set; }
        public required string passwordhash {  get; set; }
        public required string fullname { get; set; }
        public required Role role { get; set; }
        public required DateTime createat { get; set; }
        public required bool isactive { get; set; }
    }
}
