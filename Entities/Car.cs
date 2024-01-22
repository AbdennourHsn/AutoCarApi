namespace api.Entities
{
    public class Car : TreeDModel
    {
        public string Descriptiom { get; set; }
        public int Price { get; set; }
        public int MaxSpeed { get; set; }
        public string Categorie { get; set; }
        public ICollection<Image> Images { get; set; }
        public ICollection<Color> Colors {get ; set;}
        public ICollection<Wheel> Wheels {get; set;}

        public ICollection<Showroom> Showrooms { get; set; }

    }
}