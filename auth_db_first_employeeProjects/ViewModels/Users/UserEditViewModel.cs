using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace auth_db_first_employeeProjects.ViewModels.Users
{
    //public partial class User
    //{
    //    public int UserId { get; set; }

    //    public string Username { get; set; } = null!;

    //    public string PasswordHash { get; set; } = null!;

    //    public string Role { get; set; } = null!;

    //    public bool IsActive { get; set; }

    //    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    //    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();
    //}
    public class UserEditViewModel
    {
        [Required(ErrorMessage = "Invalid user.")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Username is required.")]
        [StringLength(50, ErrorMessage = "Username cannot exceed 50 characters.")]
        [Display(Name = "Username")]
        public string Username { get; set; } = null!;

        [Display(Name = "Active?")]

        public bool IsActive { get; set; }
        // List Employees
        // List Projects
    }
}
