using System;
using System.Collections.Generic;
using System.Linq;


namespace Demo_API.Services
{
    public interface ICharacterService
    {
         Task<List<Character>> GetAllCharacters();
        Task<Character> GetCharacterById(int id);
        Task<List<Character>> AddCharacter(Character newCharacter);
    }
}