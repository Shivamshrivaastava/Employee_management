using EmployeeManagement.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagement.Repositories
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllEmployees();
        Task<Employee> AddEmployee(Employee employee);
        Task<Employee?> GetEmployeeById(int id);
        Task<Employee?> UpdateEmployee(Employee employee);
        Task<bool> DeleteEmployee(int id);
    }
}
