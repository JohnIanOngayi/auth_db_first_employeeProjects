using auth_db_first_employeeProjects.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace auth_db_first_employeeProjects.ViewModels.Employees
{
    public class EmployeeEditViewModel
    {
        public int EmployeeId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Enter a valid email address.")]
        // [Remote(action: "IsEmailAvailable", controller: "RemoteValidation", ErrorMessage = "This email is already registered.")]
        [Display(Name = "Email")]
        public string Email { get; set; } = null!;
    }
}
