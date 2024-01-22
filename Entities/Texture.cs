
namespace api.Entities
{
    public class Texture
    {
        public int Id {get ; set ;}
        public string name { get; set; }
        public string FilePath { get; set; }
        public int TreeDModelId { get; set; }
        public TreeDModel TreeDModel { get; set; }
    }
}