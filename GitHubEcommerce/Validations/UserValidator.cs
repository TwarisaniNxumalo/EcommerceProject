using FluentValidation;
using FluentValidation.Results;
using GitHubEcommerce.Models;

namespace GitHubEcommerce.Validations
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.fullname).NotEmpty();
            RuleFor(u => u.email);
            RuleFor(u => u.passwordhash).NotEmpty();
            RuleFor(u => u.salt).NotEmpty();
            RuleFor(u =>u.role).NotEmpty();
          
        }
        protected override bool PreValidate(ValidationContext<User> context, ValidationResult result)
        {
            if (context.InstanceToValidate == null)
            {
                result.Errors.Add(new ValidationFailure() { ErrorMessage = "User object is null"});
                return true;
            }
            return false;
        }
    }
}
