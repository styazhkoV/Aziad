using Aziad.Data;
using Aziad.Models;

namespace Aziad.Services {
    public class OrderService {
        private readonly PizzaContext _context;
        public OrderService(PizzaContext context) => _context = context;

        public Order CreateOrder(Customer customer, List<OrderItem> items) {
            var order = new Order {
                CustomerId = customer.Id,
                Date = DateTime.Now,
                Status = "New",
                Total = items.Sum(i => i.Price * i.Quantity),
                Items = items
            };
            _context.Orders.Add(order);
            _context.SaveChanges();
            return order;
        }
    }
}
