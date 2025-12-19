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
    public class UserDetailsViewModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }  = string.Empty;
        public string Role { get; set; } = null!;
        public bool IsActive { get; set; }
        // Created Employee
        // Created Projectsd
    }
}
