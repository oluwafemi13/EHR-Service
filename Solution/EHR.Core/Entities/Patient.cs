using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR.Core.Entities
{
    public class Patient: BaseEntity
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string HomeAddress { get; set; }
        public string WorkAddress { get; set; }
        public string Email { get; set; }
        public string DOB { get; set; }
        public string sex { get; set; }
        public string MaritalStatus { get; set; }
        public string NicNo { get; set; }
        public string Religion { get; set; }
        public string Ethnic { get; set; }
        public string BloodGroup { get; set; }
        public string Genotype { get; set; }
        public string Occupation { get; set; }
        public string PhoneNumber { get; set; }
        public string Picture { get; set; }
        public string NkSurname { get; set; }
        public string NkFirstName { get; set; }
        public string NkHomeAddress { get; set; }
        public string NkWorkAddress { get; set; }
        public string NkEmail { get; set; }
        public string NkPhoneNumber { get; set; }
        public string Balance { get; set; }

        //foreignKey
        public string WardId { get; set; }

        
    }
}
