using Microsoft.AspNetCore.Mvc;


namespace dotnet_rpg.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    /* route = api/character */
    public class CharacterController : ControllerBase
    {
        private static Character knight = new Character();

        [HttpGet]
        public ActionResult<Character> Get()
        {

            return Ok(knight);
        }

    }



}