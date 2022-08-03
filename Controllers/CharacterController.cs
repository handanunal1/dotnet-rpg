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

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<Character>>>> Get()
        {

            return Ok( await _character.GetAllCharacters());
        }

       [HttpGet("{id}")]
        public async Task <ActionResult<ServiceResponse<Character>>> GetSingle(int id)
        {

            return Ok(await _character.Getcharacter(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Character>>>> AddCharacter(Character newCharacter)
        {
         
            return Ok(await _character.AddCharacter(newCharacter));

        }

    }



}