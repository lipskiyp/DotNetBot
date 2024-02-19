using Microsoft.EntityFrameworkCore;

namespace DotNetBot.Data;

public class AppDbContextFactory
{
    public AppDbContextFactory()
    {
    }

    public static void ConfigureServices(IServiceCollection services, string? dbConnectionString)
    {
        services.AddDbContext<AppDbContext>(option =>
            option.UseNpgsql(dbConnectionString)
        );
    }
}
