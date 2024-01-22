
namespace api.Entities
{
    public class Constructor : User
    {
        public string Company { get; set; }
        public Texture Logo2d { get; set; }
        public TreeDModel Logo3d { get; set; }
    }
}