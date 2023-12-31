﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR.Core.Entities
{
    public class Payment: BaseEntity
    {
        public string PatientId { get; set; }
        public Patient Patient { get; set; }
        public string PaymentFor { get; set; }
        public string Amount { get; set; }
    }
}
