using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PinPayment.Models.ViewModel
{
    public class SiteSubscriber
    {
        public string CustmerId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        [EmailAddress]
        [Required]
        [Remote("IsEmailExist", "PinPayment", ErrorMessage = "Email already exist.")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Password must be of length 6")]
        public string Password { get; set; }

        [Display(Name = "Confirm password")]
        [Required(ErrorMessage = "Enter Confirm Password")]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        [DataType(DataType.Password)]
        public string c_pwd { get; set; }



        [Display(Name = "Promo Code")]
        public string PromoCode { get; set; }


        [Display(Name = "Service Level")]
        public string ServiceLevel { get; set; }


        [Display(Name = "Campany Name")]
        public string Company { get; set; }

        public string SubscriptionId { get; set; }
    }
}