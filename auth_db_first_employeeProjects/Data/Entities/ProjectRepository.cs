using auth_db_first_employeeProjects.Data.Contracts;
using auth_db_first_employeeProjects.Models;

namespace auth_db_first_employeeProjects.Data.Entities
{
    public class ProjectRepository(CompanyManagementContext dbContext) : RepositoryBase<Project>(dbContext), IProjectRepository
    {
    }
}