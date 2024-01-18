
namespace NigeriansAtFaang.Domain.Entities;

public class NigeriansAtFaang : BaseEntity
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? MiddleName { get; set; }
    public required string Image { get; set; }
    public required string ShortBiography { get; set; }
    public required string ShortBiographySource { get; set; }
    public string? Twitter { get; set; }
    public string? LinkedIn { get; set; }
    public string? Facebook { get; set; }
    public string? Github { get; set; }

}