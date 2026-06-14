using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;  
using Aziad.Data;
using Aziad.Models;


namespace Aziad.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DrinksController : ControllerBase
    {
        private readonly PizzaContext _context;

        public DrinksController(PizzaContext context)
        {
            _context = context;
        }

        // ✅ Получить список всех напитков
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Drink>>> GetDrinks()
        {
            return await _context.Drinks.ToListAsync();
        }

        // ✅ Получить напиток по Id
        [HttpGet("{id}")]
        public async Task<ActionResult<Drink>> GetDrink(int id)
        {
            var drink = await _context.Drinks.FindAsync(id);
            if (drink == null) return NotFound();
            return drink;
        }

        // ✅ Добавить новый напиток
        [HttpPost]
        public async Task<ActionResult<Drink>> AddDrink(Drink drink)
        {
            _context.Drinks.Add(drink);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetDrink), new { id = drink.Id }, drink);
        }

        // ✅ Обновить данные напитка
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDrink(int id, Drink drink)
        {
            if (id != drink.Id) return BadRequest();

            _context.Entry(drink).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // ✅ Удалить напиток
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDrink(int id)
        {
            var drink = await _context.Drinks.FindAsync(id);
            if (drink == null) return NotFound();

            _context.Drinks.Remove(drink);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }  
}
