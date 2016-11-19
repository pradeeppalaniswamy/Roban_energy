using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RobanEnergy.Models
{
    public class UserDetail
    {
        public int ID { get; set; }
        [Required]
        [RegularExpression(@"/^[a-z ,.'-]+$/i", ErrorMessage = "Please Enter a valid name ")]
        [Display(Name = "FIRST NAME")]
        public String fname { get; set; }
        [Required]
        [RegularExpression(@"/^[a-z ,.'-]+$/i", ErrorMessage = "Please Enter a valid name ")]

        [Display(Name = "LAST NAME")]
        public String lname { get; set; }
        [Required]
        [Display(Name = "PHONE NUMBER")]
        public String PhoneNumber  { get; set; }
        [Required]
        [Display(Name = "EMAIL")]
        public String  Email { get; set; }
        [Required]
        [Display(Name = "MESSAGE")]
        public String  Message { get; set; }
    }
}