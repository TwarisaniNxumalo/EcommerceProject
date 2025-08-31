using GitHubEcommerce.Dtos;
using GitHubEcommerce.Models;

namespace GitHubEcommerce.Interfaces
{
    public interface IUserRepo
    {
        public void RegisterUser(UserDto user);
        public LogInResponse LogIn(string email, string password);
        public ICollection<User> GetUsers();
        public User GetUser(string username);
        public Guid DeleteUser(string email);
        public void UpdateUser(string email, UserDto user);
      
    }
}
c