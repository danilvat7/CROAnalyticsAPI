using System;
using Microsoft.AspNetCore.Identity;

namespace CROAnalyticsAPI.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly UserManager<IdentityUser> _userManager;

        public AuthenticationService(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }
    }
}
