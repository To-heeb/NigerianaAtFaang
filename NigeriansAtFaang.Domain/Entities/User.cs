using System.ComponentModel.DataAnnotations;

namespace NigeriansAtFaang.Domain.Entities;

public class User : BaseEntity
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Password { get; set; }

    [EmailAddress]
    public required string Email { get; set; }
    public required string Role { get; set; }
}