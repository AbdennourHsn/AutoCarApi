

namespace api.DTOs
{
    public class CarDto
    {
        public string ModelName { get; set; }
        public string FilePath { get; set; }
        public string Descriptiom { get; set; }
        public int Price { get; set; }
        public int MaxSpeed { get; set; }
        public string Categorie { get; set; }
        public int[] TexturesIds{get; set;}
        public int OwnerId { get; set; }
        public int[] ImagesIds { get; set; }
        public string Colors { get; set; }
        public int[] WheelsIds {get; set;}
        
    }
}
