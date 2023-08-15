using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR.Core.Entities
{
    public class PatientHistory: BaseEntity
    {

        public int PatientId { get; set; }
        public DateTime DateAdmitted { get; set; }
        public string ReferredBy { get; set; }
        public string Physician { get; set; }
        public string WardId { get; set; }
        public string AdmittedFor { get; set; }
        public string DateDischarged { get; set; }
        public string DischargedBy { get; set; }
        public string Remark { get; set; }
        public string Status { get; set; }
        
    }
}
