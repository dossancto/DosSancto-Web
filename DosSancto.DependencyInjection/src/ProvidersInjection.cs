using Microsoft.Extensions.DependencyInjection;
using DosSancto.DependencyInjection.Providers;

namespace DosSancto.DependencyInjection;

public static class ProvidersInjection
{
    public static IServiceCollection AddProviders(this IServiceCollection services, bool isDev)
    {
        return services
                      .AddCryptography(isDev);
    }
}

