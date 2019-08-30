using Dolittle.Commands.Validation;
using Dolittle.Runtime.Commands.Security;
using FluentValidation;

namespace Domain.Accounts
{
    public class OpenAccountInputValidation : CommandInputValidatorFor<OpenAccount>
    {
        public OpenAccountInputValidation()
        {
            RuleFor(_ => _.Owner).NotEmpty().WithMessage("Owner is required");
        }
        
    }
}