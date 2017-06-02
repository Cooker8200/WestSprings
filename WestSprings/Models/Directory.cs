using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WestSprings.Models
{
    public class Directory
    {   [Key]
        public int memberid { get; set; }
        [Display(Name = "First Name")]
        [Required]
        public string firstname { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        public string lastname { get; set; }
        [Display(Name = "Address")]
        public string address { get; set; }
        [Display(Name = "City")]
        public string city { get; set; }
        [Display(Name = "State")]
        public string state { get; set; }
        [Display(Name = "Zip Code")]
        public string zipcode { get; set; }
        [Display(Name = "Phone")]
        public string phone { get; set; }
        [Display(Name = "Email")]
        public string email { get; set; }
        [Display(Name = "Birthday")]
        public string birthday { get; set; }
        [Display(Name = "Anniversary")]
        public string anniversary { get; set; }
        [Display(Name = "Children")]
        public string children { get; set; }
        [Display(Name = "Children Birthday")]
        public string childbirthday { get; set; }

    }

    //public class Children
    //{
        
    //    public int childid { get; set; }
    //    [Display(Name = "Name")]
    //    public string childfirst { get; set; }
    //    [Display(Name = "Birthday")]
    //    public string birthday { get; set; }


    //}
}