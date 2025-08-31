using AutoMapper;
using GitHubEcommerce.Dtos;
using GitHubEcommerce.Models;

namespace GitHubEcommerce.Mappers
{
    public class MappersProfile : Profile
    {
        public MappersProfile()
        {
            CreateMap<UserDto, User>();
            CreateMap<ProductDto, Product>();
            CreateMap<OrderDto, Order>();
            CreateMap<OrderItemDto, OrderItem>();
            CreateMap<CartItemDto, CartItem>();
            CreateMap<CategoryDto, Category>();
        }
    }
}
