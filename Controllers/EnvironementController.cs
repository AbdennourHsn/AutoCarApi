
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

        [HttpGet("{id}")]
        public ActionResult<Entities.Environment> GetEnvironmentById(int id)
        {
            var env = this._context.Environments.FirstOrDefault(e => e.Id == id);
            if (env == null) return NotFound("Envirenement Not founded");
            else return Ok(env);
        }

        [HttpDelete("{id}")]
        public void DeleteEnvironment(int id)
        {
            var environmentToDelete = _context.Environments.Find(id);

            if (environmentToDelete != null)
            {
                _context.Environments.Remove(environmentToDelete);
                _context.SaveChanges();
            }
        }


    }
}