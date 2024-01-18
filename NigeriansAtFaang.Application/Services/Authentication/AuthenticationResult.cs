using NigeriansAtFaang.Domain.Entities;

namespace NigeriansAtFaang.Application.Services.Authentication;

public record AuthenticationResult
(
    User User,
    string Token
);