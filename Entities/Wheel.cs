
namespace api.Entities
{
    public class Wheel : TreeDModel
    {
        public string Descriptiom { get; set; }
        public Texture image { get; set; }
        // public Texture[] textures { get; set; }
        // public Color[] colors{get; set;}
        public int CarId { get; set; }
        public Car Car { get; set; }

    }
}