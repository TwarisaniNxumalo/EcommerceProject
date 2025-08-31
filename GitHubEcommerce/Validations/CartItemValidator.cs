using FluentValidation;
using FluentValidation.Results;
using GitHubEcommerce.Models;

namespace GitHubEcommerce.Validations
{
    public class CartItemValidator : AbstractValidator<CartItem>
    {
        public CartItemValidator()
        {
            
        }

        protected override bool PreValidate(ValidationContext<CartItem> context, ValidationResult result)
        {
            return base.PreValidate(context, result);
        }
    }
}
