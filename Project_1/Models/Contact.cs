using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project_1.Models
{
    public class Contact
    {
        [Display(Name = "Company Name")]
        public string Company_Name;
        [Display(Name = "Company Email")]
        public string Company_Email;
        [Display(Name = "Company Phone")]
        public string Company_Phone;
        [Required]
        [Display(Name = "Name")]
        public string User_Name { get; set; }
        [Required]
        [Display(Name = "Email Address")]
        public string User_Email { get; set; }
        [Required]
        [Display(Name = "Subject")]
        public string User_Subject { get; set; }
        [Required]
        [Display(Name = "Message")]
        public string User_Message { get; set; }
    }
}