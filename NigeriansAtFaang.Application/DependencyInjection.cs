using Microsoft.Extensions.DependencyInjection;
using NigeriansAtFaang.Application.Services.Authentication;

namespace NigeriansAtFaang.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();

        return services;
    }
}