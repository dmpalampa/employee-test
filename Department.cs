using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess 
{
    public class Department: BaseEntity
    {
        public string dName { get; set; }

        public string dHead { get; set; }
        public virtual ICollection<Employee> Employee { get; set; }
    }
}
