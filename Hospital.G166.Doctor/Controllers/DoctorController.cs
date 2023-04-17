using Hospital.G166.Doctor.Services;
using Microsoft.AspNetCore.Mvc;

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
            _doctorService = doctorService ? throw new ArgumentNullException(nameof(doctorService));
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

        // PUT api/<DoctorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DoctorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
