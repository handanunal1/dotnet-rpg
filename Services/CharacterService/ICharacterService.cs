namespace dotnet_rpg.Services.CharacterService
{
    public interface ICharacterService 
    {

     Task<ServiceResponse<List<Character>>> GetAllCharacters();
      Task <ServiceResponse<List<Character>>> AddCharacter(Character newCharacter);    

      Task <ServiceResponse<Character>> Getcharacter (int id);
    }
}