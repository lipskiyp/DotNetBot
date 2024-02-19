using Microsoft.EntityFrameworkCore;
using DotNetBot.Models;

namespace DotNetBot.Data;

public class AppDbContext : DbContext
{
    public DbSet<Message> Messages { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        new MessageEntityTypeConfiguration().Configure(modelBuilder.Entity<Message>());
    }
}
