using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aziad.Services {
    public class PaymentService {
        public bool ProcessPayment(int orderId, string method) {
            // Здесь будет интеграция с Kaspi/Stripe/PayPal
            return true;
        }
    }
}
