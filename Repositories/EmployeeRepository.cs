using EmployeesSystem.Models;
using EmployeesSystem.EmployeeDbContext;

namespace EmployeesSystem.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private EmployeeContext _employeeContext;
        public EmployeeRepository(EmployeeContext context)
        {
                _employeeContext = context;
        }
        public bool AddEmployee(Employee employee)
        {
            _employeeContext.Employees.Add(employee);
            _employeeContext.SaveChanges();

            return true;
        }

        public bool DeleteEmployee(Employee employee)
        {
            _employeeContext.Remove(employee);
            _employeeContext.SaveChanges();

            return true;
        }

        public List<Employee> GetAllEmployees()
        {
            return _employeeContext.Employees.ToList();
        }

        public Employee? GetEmployeeById(int id)
        {
            return _employeeContext.Employees
                .Where(e => e.Id == id)
                .FirstOrDefault();
        }
    }
}
