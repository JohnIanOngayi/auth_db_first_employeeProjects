using auth_db_first_employeeProjects.ViewModels.Employees;

namespace auth_db_first_employeeProjects.Services
{
    public interface IEmployeeService
    {
        Task<List<EmployeeDetailsViewModel>> GetAllEmployees();
        Task<EmployeeDetailsViewModel?> GetEmployee(int employeeId);
        Task UpdateEmployee (EmployeeEditViewModel employee);
        Task DeleteEmployee (int employeeId);
        Task AddEmployee(EmployeeCreateViewModel employee);
    }
}
