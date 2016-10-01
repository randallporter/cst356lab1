using lab1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab1.Controllers
{
    public class PersonController : Controller
    {
        public ActionResult Index()
        {
            Person person = new Person();
            person.Name = "I am a Person yo, I real person.";
            ViewBag.Message = person.Name;
            return View();
        }
    }
}