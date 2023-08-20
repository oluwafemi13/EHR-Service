//using Microsoft.EntityFrameworkCore.Internal;
using EHR.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR.Application.Data
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions options): base(options) { }


       
        public DbSet<Login> Logins { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Staff> Staffs { get; set;}

    }
}
