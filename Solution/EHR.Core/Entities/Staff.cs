using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR.Core.Entities
{
    public class Staff: BaseEntity
    {
        public string _fullname;

        public string Name
        {
            get { return _fullname; }
            set { _fullname = FirstName + " "+ LastName; }
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string sex { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string DOB { get; set; }
        public string PhoneNumber { get; set; }
        public string NicNo { get; set; }
        public string Qualification { get; set; }
        public string Specialization { get; set; }
        public string VisitationCharge { get; set; }
        public string ConsultationCharge { get; set; }
        public string Picture { get; set; }
        public string StaffType { get; set; }
        public string Department { get; set; }
        public string MaritalStatus { get; set; }
        public string Religion { get; set; }
        public string BloodGroup { get; set; }
        public string Genotype { get; set; }
       

    }
}
