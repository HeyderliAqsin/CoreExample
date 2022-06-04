using Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Business.Concrete
{
    public class TokenManager
    {
        private readonly IConfiguration _config;
        private readonly UserManager<T110User> _userManager;

        public TokenManager(IConfiguration config, UserManager<T110User> userManager)
        {
            _config = config;
            _userManager = userManager;
        }

        public async Task<string> GenerateToken(T110User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email,user.Email),
                new Claim(ClaimTypes.Name,user.UserName),
                new Claim("Fullname",user.Firstname+" "+user.Lastname),
            };
            var roles = await _userManager.GetRolesAsync(user);
            foreach (var role in roles)
            {
                claims.Add(new Claim("roles",role));
            }
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JWT:Key"]));
            var creds=new SigningCredentials(key,SecurityAlgorithms.HmacSha256);

            var tokenOptions = new JwtSecurityToken(
                    issuer:null,
                    audience:null,
                    claims:claims,
                    signingCredentials:creds,
                    expires:DateTime.Now.AddDays(2)
                );
            return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
        }
    }
}
