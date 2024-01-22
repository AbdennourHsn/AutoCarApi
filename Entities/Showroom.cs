
namespace api.Entities
{
    public class Showroom
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string  Descriptiom { get; set; }
        public string  DateOfCreation { get; set; }
        public int NbrOfCars { get; set; }
        public ICollection<Car> Cars {get ; set;}
        public Environment Environment{get; set;}
        public User Owner {get ; set;}
    }
}