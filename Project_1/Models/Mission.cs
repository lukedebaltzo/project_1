using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project_1.Models
{
    public class Mission
    {
        [Required]
        [Display(Name = "Mission Code")]
        public int Mission_Code { get; set; }
        [Required]
        [Display(Name = "Mission Name")]
        public string Mission_Name { get; set; }
        [Required]
        [Display(Name = "Mission President First Name")]
        public string Name_First_President { get; set; }
        [Required]       
        [Display(Name = "Mission President Last Name")]
        public string Name_Last_President { get; set; }
        [Required]
        [Display(Name = "Street Address")]
        public string Street_Address { get; set; }
        [Required]
        [Display(Name = "State")]
        public string State { get; set; }
        [Required]
        [Display(Name = "Country")]
        public string Country { get; set; }
        [Required]
        [Display(Name = "Zip Code")]
        public string Zip { get; set; }
        [Required]
        [Display(Name = "Language")]
        public string Language { get; set; }
        [Required]
        [Display(Name = "Climate")]
        public string Climate { get; set; }
        [Required]
        [Display(Name = "Main Religion")]
        public string Main_Religion { get; set; }

    }
}