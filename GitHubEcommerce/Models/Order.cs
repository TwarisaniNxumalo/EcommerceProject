using GitHubEcommerce.Enums;
using Microsoft.EntityFrameworkCore;

namespace GitHubEcommerce.Models
{
    [Comment("Table to store orders information")]
    public class Order
    {
       
        public Guid orderId {  get; set; }
        public required DateTime oderdate { get; set; }
        public required Decimal totalamount { get; set; }
        public required PaymentStatus status { get; set; }
        public required User user { get; set; }
    }
}
