using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndpointPaymentApi.Models
{
    public class AmountOfMoney
    {
        public long Amount { get; set; }
        public string CurrencyCode { get; set; }
    }
}
