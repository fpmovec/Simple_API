using System.ComponentModel.DataAnnotations;

namespace EmployeesSystem.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [MinLength(3)]
        public string Name { get; set; } = string.Empty;
        [Range(1, 100)]
        public int Age { get; set; }
    }

    public class EmployeeViewModel
    {
        [MinLength(3)]
        public string Name { get; set; } = string.Empty;
        [Range(1, 100)]
        public int Age { get; set; }
    }
}
