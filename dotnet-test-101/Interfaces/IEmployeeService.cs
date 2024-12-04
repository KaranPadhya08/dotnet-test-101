using dotnet_test_101;

public interface IEmployeeService
{
    IEnumerable<Employee> GetAll();
    Employee GetById(int id);
    void Add(Employee employee);
    void Update(Employee employee);
    void Delete(int id);
}