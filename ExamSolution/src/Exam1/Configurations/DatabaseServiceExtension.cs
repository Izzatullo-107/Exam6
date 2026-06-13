
using Exam1.Data;
using Microsoft.EntityFrameworkCore;


namespace Exam1.Configurations;

public static class DatabaseServiceExtension
{
    public static IServiceCollection AddDatabaseService(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        return services;
    }
}

