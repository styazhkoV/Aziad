using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aziad.DTOs {
    public class OrderRequestDto {
        public int CustomerId { get; set; }
        public List<int> PizzaIds { get; set; } = new();
    }
}
