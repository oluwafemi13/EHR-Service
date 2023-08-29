using EHR.Core.Contracts;
using EHR.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EHR.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IPatientRepository _patientRepo;
        public PatientController(IPatientRepository patientRepo)
        {
            _contextAccessor = _contextAccessor ?? throw new ArgumentNullException();
            _patientRepo= patientRepo;
        }

        [HttpPost("CreatePatient")]
        public async Task<IActionResult> CreatePatient([FromBody]Patient patient)
        {
             await _patientRepo.CreatePatient(patient);
            return Ok();
        }

        [HttpPost("GetPatientById")]
        public async Task<IActionResult> GetPatientById([FromBody] int Id)
        {
           var result =  await _patientRepo.GetPatientById(Id);
            if(result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpPost("GetPatientByName")]
        public async Task<IActionResult> GetPatientByName([FromBody] string Name)
        {
            var result = await _patientRepo.GetPatientByName(Name);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpPost("GetPatientByEmail")]
        public async Task<IActionResult> GetPatientByEmail([FromBody] string Email)
        {
            var result = await _patientRepo.GetPatientByEmail(Email);
            if (result == null)
                return NotFound();
            return Ok(result);
        }
    }
}
