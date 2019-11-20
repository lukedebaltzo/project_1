using Project_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Project_1.Controllers
{
    public class ContactController : Controller
    {
        
        // GET: Contact
        public ActionResult Contact()
        {
            ViewBag.Subject = SubjectController.lstSubject;
            return View();
        }

        /*  This is the code we will use if we ever want the message to actually send
         [HttpPost]
         public ActionResult Contact(string Company_Email, string User_Subject, string User_Message)
         {

             try
             {
                 if (ModelState.IsValid)
                 {
                     var senderEmail = new MailAddress("Company Email", "Company Name");
                     var receiverEmail = new MailAddress(receiver, "Receiver");
                     var password = "company email password";
                     var sub = subject;
                     var body = message;
                     var smtp = new SmtpClient
                     {
                         Host = "smtp.gmail.com",
                         Port = 587,
                         EnableSsl = true,
                         DeliveryMethod = SmtpDeliveryMethod.Network,
                         UseDefaultCredentials = false,
                         Credentials = new NetworkCredential(senderEmail.Address, password)
                     };
                     using (var mess = new MailMessage(senderEmail, receiverEmail)
                     {
                         Subject = subject,
                         Body = message
                     })
                     {
                         smtp.Send(mess);
                     }
                     return View();
                 }
             }
             catch (Exception)
             {
                 ViewBag.Error = "Some Error";
             }

             return View();

         }
          */
    }
}

 