using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndpointPaymentApi.Models
{
    public class CardPaymentMethodSpecificInput
    {
        public string Card { get; set; }
        public int PaymentProductId { get; set; }
        public bool SkipAuthentication { get; set; }
    }
}
