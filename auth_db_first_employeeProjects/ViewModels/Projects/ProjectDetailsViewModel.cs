using auth_db_first_employeeProjects.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace auth_db_first_employeeProjects.ViewModels.Projects
{
    public class ProjectDetailsViewModel
    {
        public int ProjectId { get; set; }

        public string? ProjectName { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int CreatedBy { get; set; }
        [ForeignKey("CreatedBy")]
        [ValidateNever]
        public required User CreatedByNavigation { get; set; }
    }
}
