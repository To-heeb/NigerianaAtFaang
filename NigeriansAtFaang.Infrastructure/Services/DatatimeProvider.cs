using NigeriansAtFaang.Application.Common.Interface.Services;

namespace NigeriansAtFaang.Infrastructure.Services;


public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}