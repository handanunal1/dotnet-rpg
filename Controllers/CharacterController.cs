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
        public async Task<ActionResult<List<Character>>> Get()
        {

            return Ok( await _character.GetAllCharacters());
        }

        [HttpGet]
        [Route("GetSingle")]
        public async Task <ActionResult<Character>> GetSingle(int id)
        {

            return Ok(await _character.Getcharacter(id));
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<List<Character>>> AddCharacter(Character newCharacter)
        {
         
            return Ok(await _character.AddCharacter(newCharacter));

        }

    }



}