using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    public class ColorsController : BaseApiController
    {
        private readonly DataContext _context;
        public ColorsController(DataContext context)
        {
            _context = context;
        }
        
        [HttpGet("{CarId}")]
        public async Task<IEnumerable<Color>> GetCar(int CarId){
            IEnumerable<Color> colors = await _context.Colors.Where(color=> color.CarId==CarId).ToListAsync();
            return colors;
        }

    }
}