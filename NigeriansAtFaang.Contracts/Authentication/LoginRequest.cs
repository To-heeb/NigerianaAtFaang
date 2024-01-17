using System.ComponentModel.DataAnnotations;

namespace NigeriansAtFaang.Contracts.Authentication;

public record LoginRequest
(
    string Email,
    string Password
);