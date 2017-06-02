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
        [Required]
        [Display(Name = "Send To")]
        public List<Leadership> Sendto { get; set; }
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
        [Display(Name = "Matt")]
        cooker8200

    }

    //public class Sendto
    //{
    //    public Sendto()
    //    {
    //        Sendtolist = new List<SelectListItem>();

    //    }

    //    [Display(Name = "Send To")]
    //    public int Sendid { get; set; }
    //    public IEnumerable<SelectListItem> Sendtolist { get; set; }
    //}

}