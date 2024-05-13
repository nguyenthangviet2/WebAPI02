using Microsoft.AspNetCore.Identity;

namespace WebAPI02.Repositories
{
    public interface ITokenRepository
    {
        string CreateJWTToken(IdentityUser user, List<string> roles);
    }
}
