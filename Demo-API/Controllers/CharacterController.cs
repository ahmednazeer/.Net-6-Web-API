using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Demo_API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class CharacterController:ControllerBase
    {
        private readonly ICharacterService _characterService ;
        public CharacterController(ICharacterService characterService)
        {
            _characterService=characterService;
        }

        

        [HttpPost]
        public async Task<ActionResult<Character>> AddCharacter(Character character){
            
            return Ok(await _characterService.AddCharacter(character));
        }

        [HttpGet("id")]
        public async Task<ActionResult<Character>> Get(int id){
            return Ok( await _characterService.GetCharacterById(id));
        }

        [HttpGet("getall")]
        public async Task<ActionResult<List< Character>>> GetAll(){
            return Ok(await _characterService.GetAllCharacters());
        }
    }
}