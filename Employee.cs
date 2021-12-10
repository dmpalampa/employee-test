using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Employee: BaseEntity
    {
        public string f_name { get; set; }
        public string l_name { get; set; }
        public string email { get; set; }
        public int dept_id { get; set; }
        public Department dept { get; set; }
        public int address_id { get; set; }
        public Address address { get; set; }

    }
}
