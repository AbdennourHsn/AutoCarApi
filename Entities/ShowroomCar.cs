using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Entities
{
    public class ShowroomCar
    {
        public int ShowroomId { get; set; }
        public Showroom Showroom { get; set; }

        public int CarId { get; set; }
        public Car car { get; set; }
    }
}