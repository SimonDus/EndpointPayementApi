using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndpointPaymentApi.Models
{
    public class Adress
    {
        public string AdditionalInfo { get; set; }
        public string City { get; set; }
        public string CountryCode { get; set; }
        public string HouseNumber { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
    }
}
