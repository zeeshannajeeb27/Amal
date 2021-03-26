using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmalApi.Data;
using AmalApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AmalApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatientController : ControllerBase
    {
        private readonly DataContext _context;
        public PatientController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> Get()

        {

            var Patient = await _context.Patients.ToListAsync();

            return Ok(Patient);

        }
        // [HttpGet("{id}")]
        // public  ActionResult<Patient> GetById(int id)
        // {
        //    var patient =  _context.Patients.Find(id);
        //    return patient;
        // }
         [HttpGet("{name}")]
        public  Patient GetByName(string name)
        {
           var patient =  _context.Patients.FirstOrDefault(x => x.PatientFirstName == name);
           return patient;
        }
        //  [HttpGet("patient/{MrNo}")]
        // public  ActionResult<Patient> GetBy(int num)
        // {
        //    var patient =  _context.Patients.Find(num);
        //    return patient;
        // }

        [HttpPost]
        public async Task<IActionResult> Post(Patient patient)
        {
            var Patient = await _context.Patients.AddAsync(patient);
            _context.SaveChanges();
            return Ok("Created");
        }

        [HttpPut("{id}")]
        public IActionResult Put(Patient patient,int id)
        {
            var Patient = _context.Patients.FirstOrDefault(x => x.PatientId == id);
            Patient.PatientFirstName = patient.PatientFirstName;
            Patient.PatientLastName = patient.PatientLastName;
            _context.SaveChanges();
            return Ok("Updated");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete (int id )
        {
            var Patient = _context.Patients.Find(id);
            _context.Remove(Patient);
            _context.SaveChanges(); 
            return Ok("Deleted");
        }
    }
}