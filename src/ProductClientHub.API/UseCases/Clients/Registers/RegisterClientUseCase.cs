using ProductClientHub.Communication.Reponses;
using ProductClientHub.Communication.Requests;
using ProductClientHub.Exceptions.ExceptionBase;

namespace ProductCientHub.API.UseCases.Clients.Registers;

public class RegisterClientUseCase
{
    public ResponseClient Execute(RequestClient client)
    {
        var validator = new RegisterClientValidation();

        var result = validator.Validate(client);

        if (result.IsValid)
        {
            return new ResponseClient();

        }

        var errors = result.Errors.Select(failure => failure.ErrorMessage).ToList();
        
        throw new ErrorOnValidationException(errors);
    }
}
