using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KiuFinalExam2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        [HttpPost]
        public double Square([FromForm] double x,[FromForm] double y)
        {
            return x * x + y * y;
        }
    }
}
