using EmployeesSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeesSystem.EmployeeDbContext
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
