
namespace api.Entities
{
    public class TreeDModel
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public string FilePath { get; set; }
        public ICollection<Texture> Textures{get; set;}
        public User Owner { get; set; }
    }
}