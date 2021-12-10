using DataAccess;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Service.EmployeeServ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Controllers
{
    
    [Route("emp/[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly IEmpoyeeRepository _employeeRepository;

        public EmployeeController(IEmpoyeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
            
        }

        [EnableCors("AllowOrigin")]
        [HttpGet]
        public JsonResult GetAllEmployees()
        {
            
            return Json(_employeeRepository.GetAllEmployees());
        }


        [EnableCors("AllowOrigin")]
        [HttpPost]
        public JsonResult UpdateEmployee([FromBody] Employee emp)
        {
            
            return Json(_employeeRepository.updateEmployee(emp));
        }

        [EnableCors("AllowOrigin")]
        [HttpDelete("{id}")]
        public JsonResult DeleteEmployees(int id)
        {
            return Json(_employeeRepository.DeleteEmployee(id));
        }
    }
}
