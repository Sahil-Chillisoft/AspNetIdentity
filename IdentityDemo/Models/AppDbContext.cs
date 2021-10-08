using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityDemo.Models
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<User>().Property(p => p.Id).HasColumnName("Usr_Id");
            modelBuilder.Entity<User>().Property(p => p.FirstName).HasColumnName("Usr_FirstName").HasMaxLength(100);
            modelBuilder.Entity<User>().Property(p => p.LastName).HasColumnName("Usr_LastName").HasMaxLength(100);
            modelBuilder.Entity<User>().Property(p => p.PhoneNumber).HasColumnName("Usr_ContactNumber");
            modelBuilder.Entity<User>().Property(p => p.Email).HasColumnName("Usr_Email");
        }
    }
}