using ApiResult.Builders;
using ApiResult.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ApiResult.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApiResult(this IServiceCollection services)
        {

            services.AddSingleton<IApiResult, ApiResultBuilder>();


            return services;
        }
    }

}
