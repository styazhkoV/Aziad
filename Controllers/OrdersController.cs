using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Aziad.Data;
using Aziad.Models;

namespace Aziad.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly PizzaContext _context;

        public OrdersController(PizzaContext context)
        {
            _context = context;
        }

        // ✅ Получить список всех заказов
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrders()
        {
            return await _context.Orders
                .Include(o => o.Pizza)
                .Include(o => o.Drink)
                .ToListAsync();
        }

        // ✅ Получить заказ по Id
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrder(int id)
        {
            var order = await _context.Orders
                .Include(o => o.Pizza)
                .Include(o => o.Drink)
                .FirstOrDefaultAsync(o => o.Id == id);

            if (order == null) return NotFound();
            return order;
        }

        // ✅ Создать новый заказ
        [HttpPost]
        public async Task<ActionResult<Order>> AddOrder(Order order)
        {
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetOrder), new { id = order.Id }, order);
        }

        // ✅ Обновить заказ (например, статус)
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOrder(int id, Order order)
        {
            if (id != order.Id) return BadRequest();

            _context.Entry(order).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // ✅ Удалить заказ
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            if (order == null) return NotFound();

            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
