using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WestSprings.Models;

namespace WestSprings.Controllers
{
    public class ContactController : Controller
    {
        //GET: Contact
        public ActionResult Contact()
        {
            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> ContactForm(WSContact model)
        //{

            //if (ModelState.IsValid)
            //{
                //var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                //var message = new MailMessage();
                //var sendto = model.Sendto;
                //message.To.Add(new MailAddress(sendto));  //change before live
                //message.From = new MailAddress("cooker8200@hotmail.com");  //change before live
                //message.Subject = "West Springs Contact";
                //message.Body = string.Format(body, model.Email, model.Name, model.Message);
                //message.IsBodyHtml = true;

                //using (var smtp = new SmtpClient())
                //{
                    //var credential = new NetworkCredential
                    //{
                        //UserName = "Cooker8200@hotmail.com", //delete before live
                        //Password = "MATTcook82189804!" //delete before live
                    //};
                    //smtp.Credentials = credential;
                    //smtp.Host = "smtp-mail.outlook.com";  //change to correct value
                    //smtp.Port = 587;
                    //smtp.EnableSsl = true;
                    //await smtp.SendMailAsync(message);
                    //return RedirectToAction("Sent");

                //}
            //}
        //}
    }
}