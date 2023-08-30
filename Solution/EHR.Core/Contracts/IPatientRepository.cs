using EHR.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR.Core.Contracts
{
    public interface IPatientRepository
    {
        public Task CreatePatient(Patient patient);
        public Task<Patient> GetPatientById(int Id);
        public Task<List<Patient>> GetPatientByName(string Name);
        public Task<Patient> GetPatientByEmail(string Email);
        public Task<IEnumerable<Patient>> GetPatients();
    }
}
