using Authorization.Api.Services;
using Common;
using Microsoft.AspNetCore.Mvc;

namespace Authorization.Api.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class AuthorizationController : ControllerBase
    {
        private readonly IAuthorizationService _service;
        private JwtSettings _jwtSettings;
        public AuthorizationController(IAuthorizationService service, JwtSettings settings)
        {
            _service = service;
            _jwtSettings = settings;
        }
        [HttpPost]
        public IActionResult GenerateToken(SystemUser user)
        {

            var token = _service.CreateToken(user.Email, user.Password, _jwtSettings.SecutityKey);
            return token == null ? Unauthorized() : Ok(token);
        }
    }
}
