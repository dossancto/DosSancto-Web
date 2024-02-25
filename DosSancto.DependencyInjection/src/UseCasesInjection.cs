using DosSancto.DependencyInjection.UseCases;
using Microsoft.Extensions.DependencyInjection;

namespace DosSancto.DependencyInjection;

public static class UseCasesInjection
{
    public static IServiceCollection AddUseCases(this IServiceCollection services)
      => services
                .AddUserUseCases();
}



