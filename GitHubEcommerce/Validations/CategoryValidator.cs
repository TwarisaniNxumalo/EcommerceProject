using FluentValidation;
using FluentValidation.Results;
using GitHubEcommerce.Models;
using Microsoft.AspNetCore.Identity;

namespace GitHubEcommerce.Validations
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {

        }

        protected override bool PreValidate(ValidationContext<Category> context, ValidationResult result)
        {
            return base.PreValidate(context, result);
        }

    }
}
