
using api.Data;

namespace api.Controllers
{
    public class EnvironementController : BaseApiController
    {
        private readonly DataContext _context;
        public EnvironementController (DataContext context)
        {
            _context = context;
        }

        
    }
}