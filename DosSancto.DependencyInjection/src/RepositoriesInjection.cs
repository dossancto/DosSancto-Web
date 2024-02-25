using DosSancto.Application.Features.Users.Data;
using DosSancto.Infra.Database.EF.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace DosSancto.DependencyInjection;

public static class RepositoriesInjection
{
    public static IServiceCollection AddRepositories(this IServiceCollection services, bool isDev)
    => services
              .AddScoped<IUserRepository, EFUserRepository>()
    ;
}


