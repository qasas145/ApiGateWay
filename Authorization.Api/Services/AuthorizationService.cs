using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
namespace Authorization.Api.Services
{
    public class AuthorizationService : IAuthorizationService
    {
        private readonly List<SystemUser> _users = new()
        {
            new("mohamed@mail.com", "mohamed"),
            new("ahmed@mail.com", "ahmed")
        };
        public string CreateToken(string email, string password, string SecurityKey)
        {
            var selectedUser = _users.SingleOrDefault(u => u.Email == email && u.Password == password);
            if (selectedUser is not SystemUser)
                return null;

            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecurityKey));

            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, selectedUser.Email)
            };

            var creds = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: "",
                audience: "",
                claims: claims,
                expires: DateTime.Now.AddMinutes(1),
                signingCredentials: creds);

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;

        }
    }

    public class SystemUser
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public SystemUser(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}
