using System.Linq;
using api.Data;
using api.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{

    public class UsersController : BaseApiController
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<User>>  GetUsers(){
            var users=_context.Users.ToList();
            return users;
        }

        [HttpGet("{id}")]
        public ActionResult<User>  GetUser(int id){
            var users=_context.Users.Find(id);
            return users;
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<string>> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
                return Ok("User deleted successfully!");
            }
            else
            {
                return NotFound("User not found");
            }
        }

        [HttpDelete("delete/all")]
         public async Task<ActionResult<string>> DeleteAll()
        {

            var users =  _context.Users.ToList();
            if (users != null)
            {
                foreach (var user in users) _context.Users.Remove(user);
                await _context.SaveChangesAsync();
                return Ok("User deleted successfully!");
            }
            else
            {
                return NotFound("User not found");
            }
        }
        // [HttpGet("hello")]
        // public string helloWord(){
        //     return "hello Word";
        // }

        [HttpPut("Update/all")]
         public async Task<ActionResult<User>> UpdateUser(){
            return null;
         }
    }
}