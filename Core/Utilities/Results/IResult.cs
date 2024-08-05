using System;

namespace Core.Utilities.Results
{
    public interface IResult
    {
        Boolean Success { get; }
        string Message { get; }
    }
}
