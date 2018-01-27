using Microsoft.EntityFrameworkCore;

namespace CoreWebApplication.Models
{
    public class UserDbContext : DbContext
    {
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<UserProfile>()
                .HasOne(p => p.Address)
                .WithOne(i => i.UserProfile)
                .HasForeignKey<Address>(b => b.UserProfileForeignKey);
        }

    }
}
