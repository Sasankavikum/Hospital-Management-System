using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using Hospital.G166.Patient.Data;
using Hospital.G166.Patient.Services;
using Microsoft.AspNetCore.Server.IIS.Core;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hospital.G166.Patient.Controllers
{
    [Route("api/patient")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _patientService;

        public PatientController(IPatientService patientService)
        {
            _patientService = patientService ?? throw new ArgumentNullException(nameof(patientService));
        }

        /// <summary>
        /// Get all patients
        /// </summary>
        /// <returns></returns>

        // GET: api/<PatientController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_patientService.GetPatient());
        }

        /// <summary>
        /// Get all patient by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        // GET api/<PatientController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _patientService.GetPatient(id) != null ? Ok(_patientService.GetPatient(id)) : NoContent();
        }

        /// <summary>
        /// Add Patient
        /// </summary>
        /// <param name="value"></param>

        // POST api/<PatientController>
        [HttpPost]
        public IActionResult Post([FromBody] Model.Patient patient)
        {
            return Ok(_patientService.AddPatient(patient));
        }

        /// <summary>
        /// Update the Patient
        /// </summary>
        /// <param name="patient"></param>

        // PUT api/<PatientController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Model.Patient patient)
        {
            return Ok(_patientService.UpdatePatient(patient));
        }

        /// <summary>
        /// delete patient
        /// </summary>
        /// <param name="id"></param>

        // DELETE api/<PatientController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _patientService.DeletePatient(id);

            return result.HasValue & result == true ? Ok($"Patient with ID:{id} got deleted successfully")
                : BadRequest($"Unable to delete Patient with ID:{id}");
        }
    }
}
