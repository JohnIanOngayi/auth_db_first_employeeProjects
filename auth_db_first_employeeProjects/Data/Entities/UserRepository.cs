using auth_db_first_employeeProjects.Data.Contracts;
using auth_db_first_employeeProjects.Models;

namespace auth_db_first_employeeProjects.Data.Entities
{
    public class UserRepository(CompanyManagementContext dbContext) : RepositoryBase<User>(dbContext), IUserRepository
    {
    }
}
