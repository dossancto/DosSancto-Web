using DosSancto.Application.Features.Users.UseCases;
using Microsoft.Extensions.DependencyInjection;

namespace DosSancto.DependencyInjection.UseCases;

internal static class UserUseCasesInjection
{
    public static IServiceCollection AddUserUseCases(this IServiceCollection services)
      => services
                .AddScoped<RegisterUserUseCase>()
                .AddScoped<LoginUserUseCase>()
                .AddScoped<DeleteUserUseCase>()
      ;
}




