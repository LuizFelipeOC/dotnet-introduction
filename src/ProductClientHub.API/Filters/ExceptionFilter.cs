using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ProductClientHub.Communication.Reponses;
using ProductClientHub.Exceptions.ExceptionBase;

namespace ProductCientHub.API.Filters;

public class ExcecptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        if (context.Exception is ProductsClientsHubException productsClientsHubException)
        {
            context.HttpContext.Response.StatusCode = (int)productsClientsHubException.GetHttpStatusCode();
            context.Result = new ObjectResult(new ResponseErrorMessage(productsClientsHubException.getErrors()));
        }   
        else
        {
            _ThrowUnknowError(context);
        }
    }

    private void _ThrowUnknowError(ExceptionContext context)
    {
        context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
        context.Result = new ObjectResult(new ResponseErrorMessage("Erro desconhecido."));
    }
}
