using dotnet_rpg.Dtos.Character;

namespace dotnet_rpg.Services.CharacterService
{
    public interface ICharacterService 
    {

     Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
      Task <ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto dto);    

      Task <ServiceResponse<GetCharacterDto>> Getcharacter (int id);
    }
}