

namespace api.Entities
{
    public class Color
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RGB { get; set; }

        public int CarId { get; set; }
        public Car Car { get; set; }
    }
}