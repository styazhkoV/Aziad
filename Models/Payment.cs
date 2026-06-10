using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aziad.Models {
    public class Payment {
        public int Id { get; set; }  // PK
        public int OrderId { get; set; }
        public string Method { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string TransactionId { get; set; } = string.Empty;
    }
}
