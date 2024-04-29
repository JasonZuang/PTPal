using Microsoft.AspNetCore.Mvc;

namespace PTPal.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PTPalController : Controller
    {
        [HttpGet("/")]
        public ActionResult<string> Index()
        {
            return "Hello World";
        }
    }
}