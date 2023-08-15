using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR.Core.Entities
{
    public class Ward: BaseEntity
    {
        public string WardName { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }
    }
}
