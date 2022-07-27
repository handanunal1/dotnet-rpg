namespace dotnet_rpg.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static Character knight = new Character();

        private static List<Character> characters = new List<Character> {
            new Character(),
            new Character{Id = 1,Name = "Sam"}
        };
        public List<Character> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return characters;
        }

        public List<Character> GetAllCharacters()
        {
                return characters;
        }

        public Character Getcharacter(int id)
        {
            return characters.FirstOrDefault(name => name.Id == id);
        }
    }
}