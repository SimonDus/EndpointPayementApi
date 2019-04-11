using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EndpointPaymentApi.Models
{
    public class Card
    {
        [Required]
        public string CardNumber { get; set; }
        [Required]
        public string CardholderName { get; set; }
        [Required]
        public string Cvv { get; set; }
        [Required]
        public string ExpiryDate { get; set; }
    }
}
