
using api.Data;
using api.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    public class EnvironementController : BaseApiController
    {
        private readonly DataContext _context;
        public EnvironementController (DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Entities.Environment>> GetEnvironments()
        {
            return _context.Environments.ToList();
        }
        [HttpGet("{id}")]
        public ActionResult<Entities.Environment> GetEnvironmentById(int id)
        {
            var env = this._context.Environments.FirstOrDefault(e => e.Id == id);
            if (env == null) return NotFound("Envirenement Not founded");
            else return Ok(env);
        }

        [HttpPost]
        public ActionResult<Entities.Environment> CreateEnvironment(Entities.Environment environment)
        {
            _context.Environments.Add(environment);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetEnvironmentById), new { id = environment.Id }, environment);
        }

        [HttpDelete("{id}")]
        public ActionResult<Entities.Environment> DeleteEnvironment(int id)
        {
            var environmentToDelete = _context.Environments.Find(id);

            if (environmentToDelete == null)
            {
                return NotFound();
            }

            _context.Environments.Remove(environmentToDelete);
            _context.SaveChanges();

            return environmentToDelete;
        }
        [HttpPut("{id}")]
        public IActionResult UpdateEnvironment(int id, Entities.Environment updatedEnvironment)
        {
            if (id != updatedEnvironment.Id)
            {
                return BadRequest();
            }

            var existingEnvironment = _context.Environments.Find(id);

            if (existingEnvironment == null)
            {
                return NotFound();
            }

            existingEnvironment.name = updatedEnvironment.name;
            existingEnvironment.dateOfCreation = updatedEnvironment.dateOfCreation;
            existingEnvironment.NbrOfCars = updatedEnvironment.NbrOfCars;

            _context.SaveChanges();

            return NoContent();
        }




    }
}