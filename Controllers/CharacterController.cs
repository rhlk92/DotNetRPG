using System.Collections.Generic;
using System.Linq;
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
        public IActionResult Get(){
            return Ok(_characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public IActionResult GetSingle(int id){
            return Ok(_characterService.GetCharacterById(id));
        }
        
        [HttpPost]
        public IActionResult AddCharacter(Character newCharacter){
            return Ok(_characterService.AddCharacter(newCharacter));
        }
    }
}