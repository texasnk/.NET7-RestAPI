using System.Security.Claims;

namespace RestWithASPNETUdemy.Services
{
    public interface ITokenService
    {
        string GenerateAccessToken(IEnumerable<Claim> claims);
        string GenerateRefreshToken();

        ClaimsPrincipal GetPrincipalFromExpireToken(string token);

    }
}
