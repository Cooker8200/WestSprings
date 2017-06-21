using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WestSprings.Models;
//using static WestSprings.Models.DirectoryList;

namespace WestSprings.Controllers
{
    public class ContactController : Controller
    {
        //GET: Contact
        public ActionResult Contact()
        {
            WSContact model = new WSContact();
            IEnumerable<Leadership> admins = Enum.GetValues(typeof(Leadership)).Cast<Leadership>();
            model.SendToAddresses = from admin in admins
                                    select new SelectListItem
                                    {
                                        Text = admin.ToString(),
                                        Value = ((int)admin).ToString()
                                    };
            return View(model);

        }

        public ActionResult NotSent()
        {
            return View();
        }

        public ActionResult Sent()
        {
            return View();
        }

        public ActionResult SendTo()
        {
            WSContact model = new WSContact();
            IEnumerable<Leadership> admins = Enum.GetValues(typeof(Leadership)).Cast<Leadership>();
            model.SendToAddresses = from admin in admins
                                    select new SelectListItem
                                    {
                                        Text = admin.ToString(),
                                        Value = ((int)admin).ToString()
                               };
        return View("Contact", model);
    }

    [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ContactForm(WSContact model)
        {

            if (ModelState.IsValid)
            {
                var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                var message = new MailMessage();
                var address = ((Leadership)Enum.ToObject(typeof(Leadership), model.SendToAddressId)).ToString();
                message.To.Add(new MailAddress(address +"@hotmail.com"));  
                message.From = new MailAddress(" ");  
                message.Subject = "West Springs Contact";
                message.Body = string.Format(body, model.Email, model.Name, model.Message);
                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = " ", 
                        Password = " " 
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "smtp-mail.outlook.com";  
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    await smtp.SendMailAsync(message);
                    return RedirectToAction("Sent");

                }

            }

            else
            {
                return RedirectToAction("NotSent");
            }
        }
    }
}