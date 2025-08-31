using GitHubEcommerce.Dtos;
using GitHubEcommerce.Interfaces;
using GitHubEcommerce.Models;

namespace GitHubEcommerce.Repositories
{
    public class UserRepoImpl : IUserRepo
    {
        public Guid DeleteUser(string email)
        {
            throw new NotImplementedException();
        }

        public User GetUser(string username)
        {
            throw new NotImplementedException();
        }

        public ICollection<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public LogInResponse LogIn(string email, string password)
        {
            throw new NotImplementedException();
        }

        public void RegisterUser(UserDto user)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(string email, UserDto user)
        {
            throw new NotImplementedException();
        }
    }
}
