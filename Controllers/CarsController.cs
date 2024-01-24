using System.Diagnostics;
using System.Text.Json;
using api.Data;
using api.DTOs;
using api.Entities;
using api.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    public class CarsController : BaseApiController
    {
        private readonly DataContext _context;
        private readonly IStorageService _storageService;

        public CarsController(DataContext context , IStorageService storageService)
        {
            _context = context;
            _storageService = storageService;
        }

        [HttpGet]
        public  ActionResult<IEnumerable<Car>> GetAllCars(){
            var cars = _context.Cars.ToList();
            return cars;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Car>> GetCar(int id){
            Car car = await _context.Cars.FindAsync(id);
            return car;
        }

        [HttpGet("all/{Ownerid}")]
        public async Task<IEnumerable<Car>> GetCarsByOwnerId(int Ownerid){
             IEnumerable<Car> cars = await _context.Cars
                    .Where(room=> room.Owner.UserId==Ownerid).ToListAsync();
            
            return cars;
        }
        
        [HttpPost("add")]
        [RequestSizeLimit(100_000_000)]
        public async Task<IActionResult> UploadModel([FromForm] CarDto dto, IFormFile file)
        {
            string filePath;
            try{filePath = await _storageService.SaveFile(file);}
            catch (ArgumentException ex){return BadRequest(ex.Message);}
            User owner = await _context.Users.FindAsync(dto.OwnerId);

            ICollection<Color> colors=JsonToColors(dto.Colors);
            
            Car car= new Car{
                 ModelName=dto.ModelName,
                 FilePath=filePath,
                 Descriptiom=dto.Descriptiom,
                 Price= dto.Price,
                 MaxSpeed=dto.MaxSpeed,
                 Categorie=dto.Categorie,
                 Colors=colors,
                 Owner=owner,
             };
             _context.Cars.Add(car);
             await _context.SaveChangesAsync();
            return Ok("Upload successful!");
        }

        private async  Task<string> SaveUploadedFile(IFormFile file){
            if (file == null || file.Length == 0)
            {
                 throw new ArgumentException("No file uploaded");
            }

            // Save the uploaded file
            var filePath = "assets/cars/"+file.FileName;
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            return filePath;
        } 

        private ICollection<Color> JsonToColors(string Json){
            ColorDto[] colorDtos = null;
            ICollection<Color> colors= new List<Color>(); ;
            try{
            colorDtos = JsonSerializer.Deserialize<ColorDto[]>(Json);
            }catch (Exception) { }
            foreach (ColorDto clr in colorDtos)
            {
                Console.WriteLine(clr.Name);
                colors.Add(new Color{
                    Name=clr.Name,
                    RGB=clr.RGB,
                });
            }
            return colors;
        }


        [HttpGet("file/{name}")]
        public IActionResult GetCarFile(string name)
        {
            return _storageService.GetFile(name);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<string>> DeleteCar(int id)
        {
            var car = await _context.Cars.FindAsync(id);
            if (car != null)
            {
                _context.TreeDModels.Remove(car);
                await _context.SaveChangesAsync();
                return Ok("Car deleted successfully!");
            }
            else
            {
                return NotFound("Car not found");
            }
        }

        [HttpPut("update/{id}")]
        public IActionResult UpdateCar(int id)
        {
            return null;
        }
    }

}