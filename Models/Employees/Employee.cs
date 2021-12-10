using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string f_name { get; set; }
        public string l_name { get; set; }
        public string email { get; set; }
        public int dept_id { get; set; }
        public Department dept { get; set; }

        public static explicit operator Employee(JsonResult v)
        {
            throw new NotImplementedException();
        }
    }
}
