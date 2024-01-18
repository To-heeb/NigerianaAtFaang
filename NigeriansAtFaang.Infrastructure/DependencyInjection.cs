using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NigeriansAtFaang.Application.Common.Interface.Authentication;
using NigeriansAtFaang.Application.Common.Interface.Persistence;
using NigeriansAtFaang.Application.Common.Interface.Services;
using NigeriansAtFaang.Infrastructure.Authentication;
using NigeriansAtFaang.Infrastructure.Persistence;
using NigeriansAtFaang.Infrastructure.Services;

namespace NigeriansAtFaang.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
    {

        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
        services.AddScoped<IUserRepository, UserRepository>();
        return services;
    }
}