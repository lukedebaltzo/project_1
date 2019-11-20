using Project_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_1.Controllers
{
    public class SubjectController : Controller
    {
      
        public static List<Contact> lstSubject = new List<Contact>()
        {
            new Contact {Subject_Code = "01", Subject_Desc= "Feedback"},
            new Contact {Subject_Code = "02", Subject_Desc= "Report an Issue"},
            new Contact {Subject_Code = "03", Subject_Desc= "File a Complaint"},
            new Contact {Subject_Code = "04", Subject_Desc= "Request a new Mission"},
            new Contact {Subject_Code = "05", Subject_Desc= "Licensing Inquires"},
            new Contact {Subject_Code = "06", Subject_Desc= "Other"}
        };
        // GET: Subject
        public ActionResult Index()
        {
            return View();
        }
    }
}