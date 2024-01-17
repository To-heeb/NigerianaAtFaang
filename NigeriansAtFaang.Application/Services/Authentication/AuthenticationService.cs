using NigeriansAtFaang.Application.Common.Interface.Authentication;

namespace NigeriansAtFaang.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
    }
    public AuthenticationResult Login(string Email, string Password)
    {
        return new AuthenticationResult(
           Guid.NewGuid(),
           "toheeb",
           "oyekola",
           Email,
           "eyjndn.45un/.wfwf"
       );
    }

    public AuthenticationResult Register(string FirstName, string LastName, string Email, string Password)
    {

        Guid userId = Guid.NewGuid();

        var token = _jwtTokenGenerator.GenerateToken(userId, FirstName, LastName);

        return new AuthenticationResult(
             userId,
             FirstName,
             LastName,
             Email,
             token
         );
    }
}


