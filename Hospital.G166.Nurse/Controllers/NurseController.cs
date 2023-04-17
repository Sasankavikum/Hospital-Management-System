using Microsoft.AspNetCore.Mvc;
using Hospital.G166.Nurse.Services;
using Hospital.G166.Nurse.Controllers;
using Microsoft.AspNetCore.Server.IIS.Core;
using System.Reflection.Metadata.Ecma335;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hospital.G166.Nurse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NurseController : ControllerBase
    {
        private readonly INurseService _nurseService;

        public NurseController(INurseService nurseService)
        {
            _nurseService = nurseService ?? throw new ArgumentNullException(nameof(nurseService));
        }

        /// <summary>
        /// Get all nurse
        /// </summary>
        /// <returns></returns>

        // GET: api/<NurseController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_nurseService.GetNurse());
        }

        /// <summary>
        /// Get all nurse by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/<NurseController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _nurseService.GetNurse(id) != null ? Ok(_nurseService.GetNurse(id)) : NoContent();
        }

        /// <summary>
        /// Add Nurse
        /// </summary>
        /// <param name="nurse"></param>
        // POST api/<NurseController>
        [HttpPost]
        public IActionResult Post([FromBody] Model.Nurse nurse)
        {
            return Ok(_nurseService.AddNurse(nurse));
        }

        /// <summary>
        /// Update the nurse
        /// </summary>
        /// <param name="nurse"></param>

        // PUT api/<NurseController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Model.Nurse nurse)
        {
            return Ok(_nurseService.UpdateNurse(nurse));
        }

        /// <summary>
        /// Delete nurse
        /// </summary>
        /// <param name="id"></param>

        // DELETE api/<NurseController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _nurseService.DeleteNurse(id);

            return result.HasValue & result == true ? Ok($"Nurse with ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete Nurse with ID:{id}.");
        }
    }
}
