using FluentValidation;
using FluentValidation.Results;
using GitHubEcommerce.Models;

namespace GitHubEcommerce.Validations
{
    public class OrderValidator : AbstractValidator<Order>
    {
        public OrderValidator()
        {
            
        }

        protected override bool PreValidate(ValidationContext<Order> context, ValidationResult result)
        {
            return base.PreValidate(context, result);
        }
    }
}
