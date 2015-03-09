using CodeChallenge12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeChallenge12.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new ShadeModel() { Color = Enumerable.Range(1, 50).Select(s => string.Format("{0:X}{0:X}{0:X}", s + 77)).ToList() });
        }
    }
}