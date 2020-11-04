

namespace ApiResult
{
    public interface IApiResult<TResult>
    {
         bool Success { get; }
         string Message { get; }
         TResult Data { get; }
    }
    public interface IApiResult
    {
        IApiResult<TResult> Sucess<TResult>(TResult source, string message = null);
        IApiResult<TResult> Error<TResult>(TResult source, string message = null);
        IApiResult<TResult> From<TResult>(TResult source);
    }

}
