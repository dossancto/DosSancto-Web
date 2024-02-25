using DosSancto.Adapters.Cryptographies;
using DosSancto.Infra.Providers;
using Microsoft.Extensions.DependencyInjection;

namespace DosSancto.DependencyInjection.Providers;

internal static class CryptographyInjection
{
    public static IServiceCollection AddCryptography(this IServiceCollection services, bool isDev)
    {
        return services.AddScoped<ICryptographys, TheWorstCrypt>();
    }
}


