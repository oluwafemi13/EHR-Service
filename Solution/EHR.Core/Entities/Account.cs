using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR.Core.Entities
{
    public class Account: BaseEntity
    {
        public string? PatientId { get; set; }
        public Patient? Patient { get; set; }
        public decimal Amount { get; set; }
        public string? Comment { get; set; }
        public DateTime AccountDate { get; set; }
    }
}
