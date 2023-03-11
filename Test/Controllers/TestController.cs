using Microsoft.AspNetCore.Mvc;

namespace Test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]   
        public string GetTestData()
        {
            return "This is GetTestData Function";
        }
    }
}
