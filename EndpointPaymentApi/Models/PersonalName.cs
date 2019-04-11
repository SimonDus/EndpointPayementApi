using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndpointPaymentApi.Models
{
    public class PersonalName
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string SurnamePrefix { get; set; }
        public string Title { get; set; }
    }
}
