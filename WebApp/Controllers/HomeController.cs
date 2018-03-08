using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Here can get an insurance quote on your gadgets.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Result(string gender, int age)
        {
            ViewBag.Message = "Your contact page.";
            var CalcPrem = new CalcPrem();
            ViewBag.Message = CalcPrem.CalcPremium(age, gender);
            if (ViewBag.Iferror = Convert.ToString(CalcPrem.CalcPremium(age, gender)) == "0")
            {
                ViewBag.errorMessage = "Error getting Quote";
            }

            return View();
        }
    }
}