using System;
using System.Collections.Generic;

namespace Aziad.Models {
    public class Order {
        public int Id { get; set; }
        public int CustomerId { get; set; }      
        public DateTime Date { get; set; }       
        public string Status { get; set; } = string.Empty;
        public decimal Total { get; set; }       
        public List<OrderItem> Items { get; set; } = new();
    }
}
