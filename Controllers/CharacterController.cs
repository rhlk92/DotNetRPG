using Microsoft.AspNetCore.Mvc;
using DotNetRPG.Models;

namespace DotNetRPG.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CharacterController : ControllerBase
    {
        private static Character knight = new Character();

        public IActionResult Get(){
            return Ok(knight);
        }
    }
}