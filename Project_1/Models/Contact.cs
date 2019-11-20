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
        public string Company_Name { get; set; }
        [Display(Name = "Email")]
        public string Company_Email { get; set; }
        [Display(Name = "Phone Number")]
        public string Company_Phone { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string User_Name { get; set; }
        [Display(Name = "Email Address")]
        public string User_Email { get; set; }
        [Display(Name = "Subject")]
        public string Subject_Code { get; set; }
        [Display(Name = "Subject")]
        public string Subject_Desc{ get; set; }
        [Display(Name = "Message")]
        public string User_Message { get; set; }
    }
}