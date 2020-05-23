using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotNetRPG.Models;
using DotNetRPG.Services.CharacterService;

namespace DotNetRPG.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        private static List<Character> characters = new List<Character> {
            new Character(),
            new Character {Id=1, Name="Sam"}
        };

        [HttpGet]
        public async Task<IActionResult> Get(){
            return Ok(await _characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id){
            return Ok(await _characterService.GetCharacterById(id));
        }
        
        [HttpPost]
        public async Task<IActionResult> AddCharacter(Character newCharacter){
            return Ok(await _characterService.AddCharacter(newCharacter));
        }
    }
}