using System.Data.Entity;

namespace Hitss
{
    public class BaseHitss : DbContext
    {
        public DbSet<Cat_Role> Cat_Roles { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeProject> EmployeeProjects { get; set; }
        public DbSet<Project> Projects { get; set; }
    }
}
