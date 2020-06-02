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
                new Employee(){Id=1,Name="VK",Email="abc@gmail.com",Department=Dept.HR},
                new Employee(){Id=2,Name="MAD",Email="def@gmail.com",Department=Dept.IT},
                new Employee(){Id=3,Name="ASK",Email="ghi@gmail.com",Department=Dept.Payroll}
                //new Employee(){Id=4,Name="SBR",Email="jkl@gmail.com",Department=Dept.HR}
            };
        }

        public Employee addEmployee(Employee emp)
        {
            emp.Id=_employeeList.Max(e=>e.Id) + 1;
            _employeeList.Add(emp);
            return emp;
        }

        public Employee AddEmployee(Employee emp)
        {
            throw new NotImplementedException();
        }

        public Employee DeleteEmployee(int id)
        {
            Employee emp = _employeeList.FirstOrDefault<Employee>(e=>e.Id==id);
            if(emp!=null)
            {
                _employeeList.Remove(emp);
            }
            return emp;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }

        public Employee UpdateEmployee(Employee empUpdates)
        {
            Employee emp = _employeeList.FirstOrDefault<Employee>(e => e.Id == empUpdates.Id);
            if (emp != null)
            {
                emp.Name = empUpdates.Name;
                emp.Department = empUpdates.Department;
                emp.Email = empUpdates.Email;
            }
            return emp;
        }
    }
}
