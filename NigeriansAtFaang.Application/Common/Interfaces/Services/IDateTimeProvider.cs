namespace NigeriansAtFaang.Application.Common.Interface.Services;

public interface IDateTimeProvider
{
    DateTime UtcNow { get; }
}