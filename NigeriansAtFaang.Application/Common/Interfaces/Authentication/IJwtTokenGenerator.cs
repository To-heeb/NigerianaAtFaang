using NigeriansAtFaang.Domain.Entities;

namespace NigeriansAtFaang.Application.Common.Interface.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}