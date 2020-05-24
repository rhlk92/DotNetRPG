using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetRPG.Models;
using DotNetRPG.Dtos.Character;

namespace DotNetRPG.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
        Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
        Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(int id, UpdateCharacterDto updatedCharacter);
        Task<ServiceResponse<GetCharacterDto>> DeleteCharacter(int id);
    }
}