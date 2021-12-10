using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.EmployeeServ
{
    public interface IEmpoyeeRepository
    {
        Employee AddEmployee(Employee emp);

        IEnumerable<Employee> GetAllEmployees();

        Employee DeleteEmployee(int id);

        Employee updateEmployee(Employee emp);


    }
}
