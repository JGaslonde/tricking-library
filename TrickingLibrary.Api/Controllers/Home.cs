using Microsoft.AspNetCore.Mvc;

namespace TrickingLibrary.Api.Controllers
{
    [ApiController]
    [Route("api/Home")]
    public class Home: ControllerBase
    {
        [HttpGet]
        public string Index()
        {
            return "Hello World!";
        }
        
    }
}