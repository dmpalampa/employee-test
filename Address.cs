using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Address : BaseEntity
    {
    
        public string village { get; set; }

        public string street { get; set; }
        public string city { get; set; }
        public string zip_code { get; set; }
        public virtual ICollection<Employee> Employee { get; set; }
    }
}
