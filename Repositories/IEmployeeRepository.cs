using EmployeesSystem.Models;

namespace EmployeesSystem.Repositories
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAllEmployees();
        Employee? GetEmployeeById(int id);
        bool AddEmployee(Employee employee);
        bool DeleteEmployee(Employee employee);
    }
}
