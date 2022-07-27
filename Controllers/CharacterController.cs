using dotnet_rpg.Services.CharacterService;
using Microsoft.AspNetCore.Mvc;


namespace dotnet_rpg.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    /* route = api/character */
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _character;

        public CharacterController(ICharacterService character)
    {
            _character = character;
        }

        [HttpGet]
        [Route("GetAll")]
        public ActionResult<List<Character>> Get()
        {

            return Ok(_character.GetAllCharacters());
        }

        [HttpGet]
        [Route("GetSingle")]
        public ActionResult<Character> GetSingle(int id)
        {

            return _character.Getcharacter(id);
        }

        [HttpPost]
        [Route("")]
        public ActionResult<List<Character>> AddCharacter(Character newCharacter)
        {
         
            return Ok(_character.AddCharacter(newCharacter));

        }

    }



}