using Microsoft.AspNetCore.Identity;

namespace WebAPI02.Models.DTO
{
    public class LoginResponseDTO
    {
        public string JwtToken { set; get; }
        public string Username { get;  set; }
        public string Password { get;  set; }
    }
}
