namespace Demo_API.Services
{
    public class CharacterService : ICharacterService
    {
        private List<Character> _Characters; 
        public CharacterService()
        {
             _Characters=new List<Character>(){
            new Character(){Id=1},
            new Character{Name="Ahmed",Id=2},
            new Character{Name="Mahmoud",Id=3}};
        }
        public async Task<List<Character>> AddCharacter(Character newCharacter)
        {
            _Characters.Add(newCharacter);
            return _Characters;
        }

        public async Task<List<Character>> GetAllCharacters()
        {
            return _Characters;
        }

        public async Task<Character> GetCharacterById(int id)
        {
            return _Characters.FirstOrDefault(c=>c.Id==id);
        }
    }
}