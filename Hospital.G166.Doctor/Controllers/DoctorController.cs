using Hospital.G166.Doctor.Services;
using Hospital.G166.Doctor.Data;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hospital.G166.Doctor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorService;

        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService ?? throw new ArgumentNullException(nameof(doctorService));
        }

        /// <summary>
        /// Get all doctors
        /// </summary>
        /// <returns></returns>

        // GET: api/<DoctorController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_doctorService.GetDoctors());
        }

        /// <summary>
        /// Get all doctors by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        // GET api/<DoctorController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _doctorService.GetDoctors(id) != null ? Ok(_doctorService.GetDoctors(id)) : NoContent();
        }

        /// <summary>
        /// Add Doctor
        /// </summary>
        /// <param name="value"></param>

        // POST api/<DoctorController>
        [HttpPost]
        public IActionResult Post([FromBody] Model.Doctor doctor)
        {
            return Ok(_doctorService.AddDoctor(doctor));
        }

        /// <summary>
        /// update the doctor
        /// </summary>
        /// <param name="doctor"></param>

        // PUT api/<DoctorController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Model.Doctor doctor)
        {
            return Ok(_doctorService.UpdateDoctor(doctor));
        }

        /// <summary>
        /// delete doctor
        /// </summary>
        /// <param name="id"></param>

        // DELETE api/<DoctorController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _doctorService?.DeleteDoctor(id);

            return result.HasValue & result == true ? Ok($"Doctor with ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete Doctor with ID:{id}.");
        }
    }
}
