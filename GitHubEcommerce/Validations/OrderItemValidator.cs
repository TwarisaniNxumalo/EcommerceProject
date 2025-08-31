using FluentValidation;
using FluentValidation.Results;
using GitHubEcommerce.Models;

namespace GitHubEcommerce.Validations
{
    public class OrderItemValidator : AbstractValidator<OrderItem>
    {
        public OrderItemValidator()
        {
            
        }

        protected override bool PreValidate(ValidationContext<OrderItem> context, ValidationResult result)
        {
            return base.PreValidate(context, result);
        }
    }
}
