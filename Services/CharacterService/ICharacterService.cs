namespace dotnet_rpg.Services.CharacterService
{
    public interface ICharacterService 
    {

     List<Character> GetAllCharacters();
     List<Character> AddCharacter(Character newCharacter);    

     Character Getcharacter (int id);
    }
}