using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NestLoginRegister.Models;

namespace NestLoginRegister.Contexts
{
    public class NestDbContext : IdentityDbContext<AppUser>
    {
        public NestDbContext(DbContextOptions<NestDbContext> options) : base(options)
        {

        }
    }
}
