using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aziad.Utils {
    public static class Extensions {
        public static string ToCurrency(this decimal value) {
            return $"{value:0.00} ₸";
        }
    }
}

