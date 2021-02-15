using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultaxsecond.Models
{
    public class CustomerReguest
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string WorkArea { get; set; }
    }
}
