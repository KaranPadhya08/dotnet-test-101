using Microsoft.AspNetCore.Mvc;

namespace dotnet_test_101.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static readonly List<Employee> Employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "John Doe", Position = "Software Engineer", Department = "IT", HireDate = new DateOnly(2020, 1, 15) },
            new Employee { Id = 2, Name = "Jane Smith", Position = "Project Manager", Department = "IT", HireDate = new DateOnly(2019, 3, 22) },
            new Employee { Id = 3, Name = "Emily Johnson", Position = "HR Specialist", Department = "HR", HireDate = new DateOnly(2018, 7, 30) },
            new Employee { Id = 4, Name = "Michael Brown", Position = "Accountant", Department = "Finance", HireDate = new DateOnly(2021, 5, 10) },
            new Employee { Id = 5, Name = "Jessica Davis", Position = "Marketing Coordinator", Department = "Marketing", HireDate = new DateOnly(2022, 11, 5) }
        };

        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetEmployees")]
        public IEnumerable<Employee> Get()
        {
            return Employees;
        }
    }
}