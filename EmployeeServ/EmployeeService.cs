using DataAccess;
using Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Repo;

namespace Service.EmployeeServ
{
    public class EmployeeRepository : IEmpoyeeRepository
    {
        private IRepository<Employee> employeeRepository;

        public EmployeeRepository(IRepository<Employee> employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        public Employee AddEmployee(Employee emp)
        {
            employeeRepository.Insert(emp);
            return emp;
        }

        public Employee DeleteEmployee(int id)
        {
            Employee emp = employeeRepository.Get(id);
            employeeRepository.Remove(emp);
            employeeRepository.SaveChanges();
            return emp;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return employeeRepository.GetAll();
        }

        public Employee updateEmployee(Employee emp)
        {
            employeeRepository.Update(emp);
            return emp;
        }
    }
}
