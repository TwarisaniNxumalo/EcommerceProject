using GitHubEcommerce.Enums;
using Microsoft.EntityFrameworkCore;

namespace GitHubEcommerce.Dtos
{
   
    public class OrderDto
    {
        public Guid orderId {  get; set; }
        public required DateTime oderdate { get; set; }
        public required Decimal totalamount { get; set; }
        public required PaymentStatus status { get; set; }
        public required UserDto user { get; set; }
    }
}
