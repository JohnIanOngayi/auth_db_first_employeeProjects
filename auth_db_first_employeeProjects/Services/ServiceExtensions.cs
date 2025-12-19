using auth_db_first_employeeProjects.Data;
using Microsoft.EntityFrameworkCore;

namespace auth_db_first_employeeProjects.Services
{
    public static class ServiceExtensions
    {
        public static void ConfigureMsSqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<CompanyManagementContext>(options =>
            options.UseSqlServer(connectionString)); // This requires Microsoft.EntityFrameworkCore.SqlServer
        }
    }
}
