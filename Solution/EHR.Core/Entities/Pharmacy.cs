using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR.Core.Entities
{
    public class Pharmacy: BaseEntity
    {
        public string DrugName { get; set; }
        public string Description { get; set; }
        public string Cost { get; set; }
        public string Purpose { get; set; }
        public DateTime PurchaseDate { get; set; }

    }
}
