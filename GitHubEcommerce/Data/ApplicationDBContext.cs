using GitHubEcommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace GitHubEcommerce.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            
        }

        public DbSet<UserDto> users { get; set; }
        public DbSet<ProductDto> products { get; set; }
        public DbSet<OrderDto> orders { get;set; }
        public DbSet<CartItemDto> cartItems { get; set; }
        public DbSet<OrderItemDto> orderItems { get; set; }
        public DbSet<CategoryDto> categories { get; set; }

    }
}
