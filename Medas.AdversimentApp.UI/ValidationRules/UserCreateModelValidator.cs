using FluentValidation;
using Medas.AdversimentApp.UI.Models;

namespace Medas.AdversimentApp.UI.ValidationRules
{
    public class UserCreateModelValidator:AbstractValidator<UserCreateModel>
    {
        public UserCreateModelValidator()
        {
            RuleFor(x=>x.Password).NotEmpty();
            RuleFor(x => x.Password).MinimumLength(3);
            RuleFor(x => x.Password).Equal(x => x.ConfirmPassword).WithMessage("Şifre eşleşmedi");
            RuleFor(x=>x.Username).MinimumLength(3);
            RuleFor(x => x.Username).NotEmpty();
            RuleFor(x => x.Username).Must(CanNot).WithMessage("username not contains /,.!").When(x=>x.Username!=null);
            RuleFor(x => x.GenderId).NotEmpty();
            RuleFor(x=>x.Firstname).NotEmpty();
            RuleFor(x=>x.Surname).NotEmpty();
        }

        private bool CanNot(string arg)
        {
            return !arg.Contains("/,.!");
        }
    }
}
