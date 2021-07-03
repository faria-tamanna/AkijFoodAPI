using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AkijFood.Models;
using AkijFood.Repositories;

namespace AkijFood.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColdDrinksController : ControllerBase
    {
        private readonly IDrinksRepository _drinksRepository;
        public ColdDrinksController(IDrinksRepository drinksRepository)
        {
            _drinksRepository = drinksRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<ColdDrinks>> GetDrinks()
        {
            return await _drinksRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ColdDrinks>> GetDrinks(int id)
        {
            return await _drinksRepository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<ColdDrinks>> PostDrinks([FromBody] ColdDrinks drinks)
        {
            var newdrinks = await _drinksRepository.Create(drinks);
            return CreatedAtAction(nameof(GetDrinks), new { id = newdrinks.Id }, newdrinks);
        }

        [HttpPut]
        public async Task<ActionResult> PutDrinks(int id, [FromBody] ColdDrinks drinks)
        {
            if(id != drinks.Id)
            {
                return BadRequest();
            }
            await _drinksRepository.Update(drinks);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteDrinks(int id)
        {
            var drinksToDelete = await _drinksRepository.Get(id);
            if (drinksToDelete == null)
                return NotFound();
            await _drinksRepository.Delete(drinksToDelete.Id);
            return NoContent();
        }
    }
}
