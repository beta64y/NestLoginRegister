using Microsoft.AspNetCore.Identity;

namespace NestLoginRegister.Models
{
    public class AppUser : IdentityUser
    {
        public bool IsActive { get; set; }
    }
}
