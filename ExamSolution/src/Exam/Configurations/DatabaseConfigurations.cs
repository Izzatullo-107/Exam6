using Exam.Data;
using Microsoft.EntityFrameworkCore;

namespace Exam.Configurations
{
    public class DatabaseConfigurations
    {
        public static void ConfigureDB(this WebApplicationBuilder builder)
        {
            var connectionString = builder.Configuration.GetConnectionString("DatabaseConnection");

            builder.Services.AddDbContext<AppDbContext>(options =>
              options.UseSqlServer(connectionString));
        }
    }
}
