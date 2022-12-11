using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace StudentSurvey.Models.Authentication
{
    public class jwtService
    {
        public string SecretKey { get; set; }
        public long TokenDuration { get; set; }
        private readonly IConfiguration _config;
        public jwtService(IConfiguration config)
        {
            _config = config;
            SecretKey = config.GetSection("jwtConfig").GetSection("Key").Value;

            TokenDuration = int.Parse(config.GetSection("jwtConfig").GetSection("Duration").Value);
        }
        public string GenerateToken(string id, string Email, string department)

        {
            var Key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecretKey));
            var signature = new SigningCredentials(Key, SecurityAlgorithms.HmacSha256);
            var payLoad = new[]
            {
                new Claim("id",id),
                new Claim("Email",Email),
                new Claim("department",department),
            };
            var jwtToken = new JwtSecurityToken(
                issuer: "localhost",
                audience: "localhost",
                claims: payLoad,
                  expires: DateTime.Now.AddMinutes(TokenDuration),

                signingCredentials: signature


                );
            return new JwtSecurityTokenHandler().WriteToken(jwtToken);
        }
    }
}
