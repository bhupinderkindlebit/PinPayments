using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PinPayment.Models.ViewModel
{
    public class CardDetail
    {
        [Required]
        public string accountType { get; set; }
        [Required]
        public string cardNumber { get; set; }
        [Required]
        public string cardType { get; set; }
        [Required]
        public string verificationValue { get; set; }
        [Required]
        public int month { get; set; }
        [Required]
        public int year { get; set; }
        [Required]
        public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }
        
        public string token { get; set; }
    }
}