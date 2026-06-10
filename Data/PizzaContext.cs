using Microsoft.EntityFrameworkCore;
using Aziad.Models;

namespace Aziad.Data {
    public class PizzaContext : DbContext {
        public PizzaContext(DbContextOptions<PizzaContext> options) : base(options) {}

        public DbSet<Pizza> Pizzas { get; set; } = null!;
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<OrderItem> OrderItems { get; set; } = null!;
        public DbSet<Payment> Payments { get; set; } = null!;
    }
}
