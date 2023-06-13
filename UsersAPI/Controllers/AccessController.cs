using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UsersAPI.Authorization;

namespace UsersAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class AccessController : ControllerBase
    {
        [HttpPost]
        [Authorize(Policy = "MinimunAge")]
        public IActionResult Get()
        {
            
            return Ok("Access ok!");
        }
    }
}
