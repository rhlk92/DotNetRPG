using System.Collections.Generic;
using DotNetRPG.Models;

namespace DotNetRPG.Services.CharacterService
{
    public interface ICharacterService
    {
        List<Character> GetAllCharacters();
        Character GetCharacterById(int id);
        List<Character> AddCharacter(Character character);
    }
}