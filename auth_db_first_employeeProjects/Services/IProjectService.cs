using auth_db_first_employeeProjects.Models;
using auth_db_first_employeeProjects.ViewModels.Projects;

namespace auth_db_first_employeeProjects.Services
{
    public interface IProjectService
    {
        Task<List<Project>> GetAllProjects();
        Task<Project?> GetProjectById(int id);
        Task UpdateProject(ProjectEditViewModel model);
        Task DeleteProject(int id);
    }
}
