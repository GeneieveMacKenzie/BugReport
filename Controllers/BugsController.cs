namespace BugReport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BugsController : ControllerBase
    {
        private readonly BugsService _bs;
        public BugsController(BugsService bs)
        {
            _bs = bs
        }
        [HttpGet]
        public ActionResult<IEnumerable<Bug>> Get()
        {
            tr
        }

    }
}