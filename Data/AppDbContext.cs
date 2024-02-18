using Microsoft.EntityFrameworkCore;
using DotNetBot.Models;

namespace DotNetBot.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Message> Messages { get; set; }
}
