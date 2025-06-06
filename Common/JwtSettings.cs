namespace Common
{
    public class JwtSettings
    {

        public string SecutityKey { get; set; }
        public string Issuer { get; set; }
        public string Audiance { get; set; }
        public int TokenExpiryInMinutes { get; set; }

    }
}
