

namespace ApiResult
{
    public interface IApiResult<TResult>
    {
         bool Success { get; }
         string Message { get; }
         TResult Data { get; }
    }
}
