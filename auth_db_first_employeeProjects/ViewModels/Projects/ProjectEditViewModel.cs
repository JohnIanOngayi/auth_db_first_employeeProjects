using auth_db_first_employeeProjects.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace auth_db_first_employeeProjects.ViewModels.Projects
{
    public class ProjectEditViewModel
    {
        public int ProjectId { get; set; }

        [Required]
        [DisplayName("Project Name")]
        [StringLength(100, ErrorMessage = "Name cannot be longer 100 chars")]
        public string? ProjectName { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        //Navigation
        public ICollection<Employee>? AssignedEmployees { get; set; }

        [NotMapped]
        public string? DisplayText => $"{ProjectId} - {ProjectName}";
    }
}
