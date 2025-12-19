using auth_db_first_employeeProjects.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace auth_db_first_employeeProjects.ViewModels.Employees
{
    public class EmployeeDetailsViewModel
    {
        public int EmployeeId { get; set; }

        public string? Name { get; set; }

        public string Email { get; set; } = null!;

        //public int CreatedBy { get; set; }
        //[ForeignKey("CreatedBy")]
        //[ValidateNever]
        //public required User CreatedByNavigation { get; set; }

        public ICollection<Project>? AssignedToProjects { get; set; }

        [NotMapped]
        public string? DisplayText => $"{EmployeeId} - {Name}".Trim();
    }
}
