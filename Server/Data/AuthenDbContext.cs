using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorAuthencation.Server.Data
{
    public class AuthenDbContext : IdentityDbContext
    {
        public AuthenDbContext(DbContextOptions<AuthenDbContext> options) : base(options)
        {

        }
    }
}
