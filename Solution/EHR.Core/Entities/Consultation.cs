using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR.Core.Entities;

public class Consultation: BaseEntity
{
    [ForeignKey("Patient")]
    public string PatientId { get; set; }
    public Patient Patient { get; set; }
    public string Doctor { get; set; }
    public DateTime AppointmentDate { get; set; }
    public string Note { get; set; }

}
