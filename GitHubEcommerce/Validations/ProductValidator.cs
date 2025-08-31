using FluentValidation;
using FluentValidation.Results;
using GitHubEcommerce.Models;

namespace GitHubEcommerce.Validations
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            
        }


        protected override bool PreValidate(ValidationContext<Product> context, ValidationResult result)
        {
           if(context.InstanceToValidate == null)
            {
                result.Errors.Add(new ValidationFailure() { ErrorMessage = "Product object is null" });
                return true;
            }
           return false;

        }
    }
}
