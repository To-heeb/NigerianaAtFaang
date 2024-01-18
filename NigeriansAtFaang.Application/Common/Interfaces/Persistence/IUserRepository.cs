using NigeriansAtFaang.Domain.Entities;

namespace NigeriansAtFaang.Application.Common.Interface.Persistence;

public interface IUserRepository
{
    User? GetUserByEmail(string email);
    void Add(User user);
}