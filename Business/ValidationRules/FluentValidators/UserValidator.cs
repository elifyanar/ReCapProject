using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty().MinimumLength(3); ;
            RuleFor(u => u.LastName).NotEmpty().MinimumLength(3); ;
            RuleFor(u => u.Password).NotEmpty().MinimumLength(6);
            RuleFor(u => u.Email).EmailAddress();
            RuleFor(u => u.UserId).NotEmpty();
          
          }
    }
}
