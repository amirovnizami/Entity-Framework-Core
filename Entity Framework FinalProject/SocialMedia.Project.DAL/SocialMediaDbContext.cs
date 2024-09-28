using Microsoft.EntityFrameworkCore;
using SocialMedia.Project.Models.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SocialMedia.Project.DAL;


public class SocialMediaDbContext : DbContext
{
    //public SocialMediaDbContext(DbContextOptions<SocialMediaDbContext> options)
    //    : base(options)
    //{ }
    public DbSet<UserDetails> UserDetails { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<User> Users { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=Acer;Initial Catalog = SocialMediaDb;Trusted_Connection=True;TrustServerCertificate=True;");
        base.OnConfiguring(optionsBuilder);
    }
}


