using System.Net;

namespace ProductClientHub.Exceptions.ExceptionBase;

public abstract class ProductsClientsHubException : SystemException
{
    public ProductsClientsHubException(string errorMessage) : base(errorMessage)
    {
    }

    public abstract List<string> getErrors();
    public abstract HttpStatusCode GetHttpStatusCode();
}
