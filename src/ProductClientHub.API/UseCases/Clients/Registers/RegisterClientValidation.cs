using FluentValidation;
using ProductClientHub.Communication.Requests;

namespace ProductCientHub.API.UseCases.Clients.Registers;

public class RegisterClientValidation : AbstractValidator<RequestClient>
{
    public RegisterClientValidation()
    {
        RuleFor(client => client.Name).NotEmpty().WithMessage("O nome não pode ser vazio.");
        RuleFor(client => client.Email).EmailAddress().WithMessage("O e-mail não é valído.");
    }
}
