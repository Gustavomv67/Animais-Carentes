using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Animais_Carentes.Models;

namespace Animais_Carentes.Controllers
{
    public class HomeController : Controller
    {
        private contexto db = new contexto();
        public ActionResult Index()

        {
            return View(db.OngModels.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}