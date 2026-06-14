using System;
using System.Collections.Generic;

namespace Aziad.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; } = string.Empty;
        public decimal Total { get; set; }

        // 🔗 Связь с клиентом
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }

        // 🔗 Состав заказа
        public List<OrderItem> Items { get; set; } = new();

        // 🔗 Связь с пиццей
        public int? PizzaId { get; set; }
        public Pizza? Pizza { get; set; }

        // 🔗 Связь с напитком
        public int? DrinkId { get; set; }
        public Drink? Drink { get; set; }

        // Флаг комбо
        public bool Combo { get; set; }
    }
}




