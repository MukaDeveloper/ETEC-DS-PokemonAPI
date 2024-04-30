using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PokemonApi.Data;
using PokemonApi.Models;

namespace PokemonApi.Controllers {
    [ApiController]
    [Route("[Controller]")]
    public class PokemonController : ControllerBase {
        private readonly DataContext _context;

        public PokemonController(DataContext context) {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) {
            try {
                Pokemon pokemon = await _context.TB_POKEMONS.FirstOrDefaultAsync((p) => p.Id == id);
                return Ok(pokemon);
            } catch (System.Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() {
            try {
                List<Pokemon> pokemons = await _context.TB_POKEMONS.ToListAsync();
                return Ok(pokemons);
            } catch (System.Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreatePokemon(Pokemon pokemon) {
            try {
                if (pokemon.Nome != null && pokemon.Genero != null && pokemon.Tipo != null) {
                    await _context.TB_POKEMONS.AddAsync(pokemon);
                    await _context.SaveChangesAsync();
                    return Ok(pokemon);
                } else {
                    return BadRequest("Insira um nome válido, um gênero válido e/ou um tipo válido.");
                }
            } catch (System.Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}