using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultaxsecond.Models
{
    public class Blog
    {
        public int ID { get; set; }
        public string Header { get; set; }
        public string description { get; set; }
        public DateTime Publishdate { get; set; }
        public int categoryId { get; set; }
    }
}


