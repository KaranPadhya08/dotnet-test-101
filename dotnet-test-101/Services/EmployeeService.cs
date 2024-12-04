using dotnet_test_101;

public class EmployeeService : IEmployeeService
{
    private readonly List<Employee> _employees = new List<Employee>
    {
        new Employee { Id = 1, Name = "John Doe", Position = "Software Engineer", Department = "IT", HireDate = new DateOnly(2020, 1, 15) },
        new Employee { Id = 2, Name = "Jane Smith", Position = "Project Manager", Department = "IT", HireDate = new DateOnly(2019, 3, 22) },
        new Employee { Id = 3, Name = "Emily Johnson", Position = "HR Specialist", Department = "HR", HireDate = new DateOnly(2018, 7, 30) },
        new Employee { Id = 4, Name = "Michael Brown", Position = "Accountant", Department = "Finance", HireDate = new DateOnly(2021, 5, 10) },
        new Employee { Id = 5, Name = "Jessica Davis", Position = "Marketing Coordinator", Department = "Marketing", HireDate = new DateOnly(2022, 11, 5) }
    };

    public IEnumerable<Employee> GetAll()
    {
        return _employees;
    }

    public Employee GetById(int id)
    {
        return _employees.FirstOrDefault(e => e.Id == id);
    }

    public void Add(Employee employee)
    {
        _employees.Add(employee);
    }

    public void Update(Employee employee)
    {
        var existingEmployee = GetById(employee.Id);
        if (existingEmployee != null)
        {
            existingEmployee.Name = employee.Name;
            existingEmployee.Position = employee.Position;
            existingEmployee.Department = employee.Department;
            existingEmployee.HireDate = employee.HireDate;
        }
    }

    public void Delete(int id)
    {
        var employee = GetById(id);
        if (employee != null)
        {
            _employees.Remove(employee);
        }
    }
}