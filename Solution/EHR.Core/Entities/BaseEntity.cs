using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR.Core.Entities
{
    public class BaseEntity
    {
        public string Id { get; set; }
        public DateTime CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
