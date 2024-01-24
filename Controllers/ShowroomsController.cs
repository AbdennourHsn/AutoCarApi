using System.Diagnostics;
using api.Data;
using api.DTOs;
using api.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    public class ShowroomsController : BaseApiController
    {
        private readonly DataContext _context;

        public ShowroomsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public  ActionResult<IEnumerable<Showroom>> GetAllShowrooms(){
            var showroom = _context.Showrooms.ToList();
            return showroom;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Showroom>> GetShowroom(int id){
            Showroom showroom = await _context.Showrooms.FindAsync(id);
            return showroom;
        }

        [HttpGet("user/{UserId}")]
        public async Task<IEnumerable<Showroom>> GetRoomsByOwnerId(int UserId){
            Console.WriteLine("ownerId =" +UserId);

            IEnumerable<Showroom> rooms = await _context.Showrooms
                    .Where(room=> room.Owner.UserId==UserId).ToListAsync();
            Console.WriteLine("ownerId =" + rooms);
            return rooms;
        }
        
        [HttpPost("create")]
        public async Task<ActionResult<Showroom>> CreateShowroom(ShowroomDto dto){
            User owner = await _context.Users.FindAsync(dto.OwnerId);
            var showroom= new Showroom{
                Name=dto.Name,
                Descriptiom=dto.Descriptiom,
                DateOfCreation= dto.DateOfCreation,
                NbrOfCars=dto.NbrOfCars,
                Owner=owner
            };
            // foreach(int nbt in dto.Cars) Console.WriteLine(nbt);
            _context.Showrooms.Add(showroom);
            await _context.SaveChangesAsync();
            return showroom;
        }

        [HttpPut("/update/{id}")]
        public async Task<ActionResult<Showroom>> UpdateShoweoom(){
            return null;
        }
        
        [HttpDelete("delete/{id}")]
        public async Task<ActionResult<string>> DeleteShowroom(int id)
        {
            Showroom showroom = await _context.Showrooms.FindAsync(id);
            if (showroom != null)
            {
                _context.Showrooms.Remove(showroom);
                await _context.SaveChangesAsync();
                return Ok("Showroom deleted successfully!");
            }
            else
            {
                return NotFound("Showroom not found");
            }
        }

        [HttpDelete("delete/all")]
        public async Task<ActionResult<string>> DeleteAllShowrooms()
        {
            DbSet<Showroom> showrooms = _context.Showrooms;
            foreach(Showroom room in showrooms){
                _context.Showrooms.Remove(room);
            }
            await _context.SaveChangesAsync();
            return Ok("Showroom deleted successfully!");
        }
    }
}