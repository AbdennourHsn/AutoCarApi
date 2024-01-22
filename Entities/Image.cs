using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Entities
{
    public class Image
    {
        public int Id {get ; set ;}
        public string ImagePath { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
    }
}