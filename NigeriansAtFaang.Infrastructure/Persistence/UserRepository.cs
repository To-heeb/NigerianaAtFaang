using NigeriansAtFaang.Application.Common.Interface.Persistence;
using NigeriansAtFaang.Domain.Entities;

namespace NigeriansAtFaang.Infrastructure.Persistence;

public class UserRepository : IUserRepository
{
    private static readonly List<User> _users = new List<User>();
    public void Add(User user)
    {
        _users.Add(user);
    }

    public User? GetUserByEmail(string email)
    {
        return _users.Where(u => u.Email == email).FirstOrDefault();
    }
}