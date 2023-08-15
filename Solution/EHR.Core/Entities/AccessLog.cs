using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR.Core.Entities
{
    public class AccessLog
    {
        public string UserName { get; set; }
        public string ComputerName { get; set; }
        public DateTime LogDate { get; set; }
        public string Description { get; set; }
    }
}
