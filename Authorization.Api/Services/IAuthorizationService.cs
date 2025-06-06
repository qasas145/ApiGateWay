namespace Authorization.Api.Services
{
    public interface IAuthorizationService
    {
        public string CreateToken(string email, string password, string securityToken);
    }
}
