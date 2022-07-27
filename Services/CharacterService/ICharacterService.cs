namespace dotnet_rpg.Services.CharacterService
{
    public interface ICharacterService 
    {

     Task <List<Character>> GetAllCharacters();
      Task <List<Character>> AddCharacter(Character newCharacter);    

      Task <Character> Getcharacter (int id);
    }
}