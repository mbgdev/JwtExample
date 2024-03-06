using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AuthServer.Core.Models;

namespace AuthServer.Data
{
    
    public class AppDbContext : IdentityDbContext<UserApp, IdentityRole, string>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)

        {
        }

        public DbSet<Product> Produts { get; set; }

        public DbSet<UserRefreshToken> UserRefreshTokens { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(GetType().Assembly);

            base.OnModelCreating(builder);
        }
    }
}