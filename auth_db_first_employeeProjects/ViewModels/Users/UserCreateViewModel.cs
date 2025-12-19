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
    public class UserCreateViewModel
    {
        [Required(ErrorMessage = "Username is required.")]
        [StringLength(50, ErrorMessage = "Username cannot exceed 50 characters.")]
        [Display(Name = "First Name")]
        public string Username { get; set; } = null!;

        [Display(Name = "Active?")]
        public bool IsActive { get; set; } = true;

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(100, MinimumLength = 8,
            ErrorMessage = "Password must be at least {2} characters long.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; } = null!;

        [Required(ErrorMessage = "Please confirm the password.")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Passwords do not match.")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; } = null!;
    }
}
