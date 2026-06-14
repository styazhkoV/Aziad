using Microsoft.EntityFrameworkCore;
using Aziad.Models;

namespace Aziad.Data {
    public class PizzaContext : DbContext {
        public PizzaContext(DbContextOptions<PizzaContext> options) : base(options) {}

        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

    }
}
