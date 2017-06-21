using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using static WestSprings.Models.DirectoryList;

namespace WestSprings.Models
{
    public class WSContact
    {
        public WSContact()
        {
            SendToAddresses = new List<SelectListItem>();

        }

        [Display(Name = "Send To")]
        public int SendToAddressId { get; set; }
        public IEnumerable<SelectListItem> SendToAddresses { get; set; }
        //[Required]
        //[Display(Name = "Send To")]
        //public List<Leadership> SendToAdmin { get; set; }
        [Required]
        [Display(Name="Your Email")]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Display(Name="Your Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name="Your Message")]
        public string Message { get; set; }

    }


    public enum Leadership
    {
        SendTo,
        [Display(Name = "Tim McDonnell")]
        TimMcDonnell,
        [Display(Name = "Justin Brunk")]
        JustinBrunk,
        [Display(Name = "Dan Kneehast")]
        DanKneehast,
        [Display(Name = "Gloria McDonnell")]
        GloriaMcDonnell,
        [Display(Name = "Tim Thompson")]
        TimThompson,
        [Display(Name = "Carol Varner")]
        CarolVarner,
        [Display(Name = "Ryan McDonnell")]
        RyanMcDonnell,
        [Display(Name = "Elders of West Springs")]
        EldersofWS,
        

    }

    public class SendToAddress
    {
        
    }

}