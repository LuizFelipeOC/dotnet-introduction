using System;

namespace ProductClientHub.Communication.Reponses;

public class ResponseErrorMessage
{
    public List<string> Errors { get; private set; }

    public ResponseErrorMessage(string message)
    {
        Errors = [message];
    }

    public ResponseErrorMessage(List<string> message)
    {
        Errors = message;
    }
}
