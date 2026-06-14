using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aziad.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Method { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;

        // 🔗 Связь с заказом
        public int OrderId { get; set; }
        public Order? Order { get; set; }
    }
}

