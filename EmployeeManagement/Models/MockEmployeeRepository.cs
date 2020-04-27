using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){Id=1,Name="VK",Email="abc@gmail.com",Department="abc"},
                new Employee(){Id=2,Name="MAD",Email="def@gmail.com",Department="def"},
                new Employee(){Id=3,Name="ASK",Email="ghi@gmail.com",Department="ghi"}
            };
        }
        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
