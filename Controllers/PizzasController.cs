using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Aziad.Data;
using Aziad.Models;

namespace Aziad.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class PizzasController : ControllerBase {
        private readonly PizzaContext _context;
        public PizzasController(PizzaContext context) => _context = context;

        [HttpGet]
        public async Task<IEnumerable<Pizza>> Get() => await _context.Pizzas.ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<Pizza>> GetById(int id) {
            var pizza = await _context.Pizzas.FindAsync(id);
            if (pizza == null) return NotFound();
            return pizza;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Pizza pizza) {
            _context.Pizzas.Add(pizza);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = pizza.Id }, pizza);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Pizza pizza) {
            if (id != pizza.Id) return BadRequest();
            _context.Entry(pizza).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) {
            var pizza = await _context.Pizzas.FindAsync(id);
            if (pizza == null) return NotFound();
            _context.Pizzas.Remove(pizza);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
