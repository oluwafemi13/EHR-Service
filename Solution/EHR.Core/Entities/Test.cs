using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR.Core.Entities
{
    public class Test: BaseEntity
    {
        public string PatientId { get; set; }
        public Patient Patient { get; set; }
        public string MedTest { get; set; }
        public string Diagnosis { get; set; }
        public DateTime Date { get; set; }
        public string Remark { get; set; }
        public string Doctor { get; set; }
        public string Image { get; set; }

    }
}
