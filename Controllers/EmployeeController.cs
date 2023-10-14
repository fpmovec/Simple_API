using EmployeesSystem.Models;
using EmployeesSystem.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository repository)
        {
            _employeeRepository = repository;
        }

        [HttpGet("/get")]
        public ActionResult<List<Employee>> Get()
        {
            var employees = _employeeRepository.GetAllEmployees();

            return Ok(employees);
        }

        [HttpPost("/post")]
        public ActionResult Post(EmployeeViewModel emp)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _employeeRepository.AddEmployee(new Employee()
            {
                Name = emp.Name,
                Age = emp.Age,
            });

            return Ok();
        }

        [HttpGet("/get/{id}")]
        public ActionResult<Employee> GetEmployeeById(int id)
        {
            var employee = _employeeRepository.GetEmployeeById(id);

            if (employee == null)
                return NotFound();

            return Ok(employee);
        }

        [HttpDelete("/delete/{id}")] 
        public ActionResult DeleteEmployeeById(int id) 
        {
            var employee = _employeeRepository.GetEmployeeById(id);

            if (employee == null)
                return NotFound();

            _employeeRepository.DeleteEmployee(employee);
            return Ok();
        }
    }
}
