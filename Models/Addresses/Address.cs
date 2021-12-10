using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Address
    {
        public int id { get; set; }
        public string village { get; set; }

        public string street { get; set; }
        public string city { get; set; }
        public string zip_code { get; set; }
    }
}
