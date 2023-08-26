using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR.Core.Entities
{
    public class Login: BaseEntity
    {
        public string Levels { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public bool IsLock { get; set; }
        public int FailedCount { get; set; }
        public int CountThreshold { get; set; }

    }
}
