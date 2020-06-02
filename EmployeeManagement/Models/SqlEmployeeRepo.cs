using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class SqlEmployeeRepo : IEmployeeRepository
    {
        private readonly AppDbContext context;

        public SqlEmployeeRepo(AppDbContext context)
        {
            this.context = context;
        }

        public Employee addEmployee(Employee emp)
        {
            context.Employees.Add(emp);
            context.SaveChanges();
            return emp;
        }

        public Employee DeleteEmployee(int id)
        {
           Employee employee = context.Employees.Find(id);
            if (employee != null)
            {
                context.Employees.Remove(employee);
                context.SaveChanges();

            }
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return context.Employees;
        }

        public Employee GetEmployee(int Id)
        {
            return context.Employees.Find(Id);
        }

        public Employee UpdateEmployee(Employee empUpdates)
        {
            var employee = context.Employees.Attach(empUpdates);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return empUpdates;
        }
    }
}
