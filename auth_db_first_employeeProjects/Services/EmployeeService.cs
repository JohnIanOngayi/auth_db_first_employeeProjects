using auth_db_first_employeeProjects.Data.Contracts;
using auth_db_first_employeeProjects.Models;
using auth_db_first_employeeProjects.ViewModels.Employees;

namespace auth_db_first_employeeProjects.Services
{
    public class EmployeeService(IEmployeeRepository employeeRepository) : IEmployeeService
    {
        private readonly IEmployeeRepository _dbContext = employeeRepository;

        public async Task AddEmployee(EmployeeCreateViewModel employee)
        {
            Employee emp = new Employee
            {
                EmployeeId = 0,
                Name = employee.Name!,
                Email = employee.Email,
                CreatedBy = 1,
            };

            await _dbContext.CreateAsync(emp);
        }

        public async Task DeleteEmployee(int employeeId)
        {
            var employee = await _dbContext.FindOneAsync(emp => emp.EmployeeId == employeeId);
            if (employee == null) return;

            await _dbContext.DeleteAsync(employee);
        }

        public async Task<List<EmployeeDetailsViewModel>> GetAllEmployees()
        {
            var employees = await _dbContext.GetAllAsync();
            List<EmployeeDetailsViewModel> allEmps = new();
            foreach(var employee in employees)
            {
                var vm = new EmployeeDetailsViewModel
                {
                    EmployeeId = employee.EmployeeId,
                    Name = employee.Name,
                    Email = employee.Email,
                    AssignedToProjects = new List<Project>()
                };

                allEmps.Add(vm);
            }

            return allEmps;
        }

        public async Task<EmployeeDetailsViewModel?> GetEmployee(int employeeId)
        {
            var employee = await _dbContext.FindOneAsync(emp => emp.EmployeeId == employeeId);
            if (employee == null) return null;

            return new EmployeeDetailsViewModel
            {
                EmployeeId = employee.EmployeeId,
                Name = employee.Name,
                Email = employee.Email,
                AssignedToProjects = new List<Project>()
            };
        }

        public async Task UpdateEmployee(EmployeeEditViewModel model)
        {
            var employee = await _dbContext.FindOneAsync(emp => emp.EmployeeId == model.EmployeeId);
            if (employee == null) return;

            employee.Name = model.Name!;
            employee.Email = model.Email;

            await _dbContext.UpdateAsync(employee);
        }
    }
}
