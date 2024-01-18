using Microsoft.AspNetCore.Mvc;
using NigeriansAtFaang.Application.Services.Authentication;
using NigeriansAtFaang.Contracts.Authentication;

namespace NigeriansAtFaang.Api.Controllers;


[ApiController]
[Route("api/v1/auth")]
public class AuthenticationController : ControllerBase
{

    private readonly IAuthenticationService _authenticationService;


    public AuthenticationController(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    [Route("register")]
    [HttpPost]
    public IActionResult Register([FromBody] RegisterRequest request)
    {
        var authResult = _authenticationService.Register(
            request.FirstName,
            request.LastName,
            request.Email,
            request.Password);

        var response = new AuthenticationResponse(
            authResult.User.Id,
            authResult.User.FirstName,
            authResult.User.LastName,
            authResult.User.Email,
            authResult.Token
            );

        return Ok(response);
    }

    [Route("login")]
    [HttpPost]
    public IActionResult Login([FromBody] LoginRequest request)
    {
        var authResult = _authenticationService.Login(
           request.Email,
           request.Password);

        var response = new AuthenticationResponse(
            authResult.User.Id,
            authResult.User.FirstName,
            authResult.User.LastName,
            authResult.User.Email,
            authResult.Token
            );

        return Ok(response);
    }

}