
using CROAnalyticsAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CROAnalyticsAPI.Controllers
{

    [Route("api/auth")]
    public class AuthenticationController : Controller
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }
        //public IActionResult Login(string username, string password)
        //{

        //}

        //public IActionResult Register(string username, string password)
        //{

        //}
    }
}
