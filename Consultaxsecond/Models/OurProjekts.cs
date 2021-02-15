using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultaxsecond.Models
{
    public class OurProjekts
    {
        public int ID { get; set; }
        public string Header { get; set; }
        public string description { get; set; }
        public string Icon { get; set; }
        public string PhotoUrl { get; set; }
        public DateTime Publishdate { get; set; }
    }
}
