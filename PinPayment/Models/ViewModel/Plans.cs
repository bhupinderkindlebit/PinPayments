using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PinPayment.Models.ViewModel
{
    public class Plans
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; }
        public string ServiceLevel { get; set; }

        

    }
}
