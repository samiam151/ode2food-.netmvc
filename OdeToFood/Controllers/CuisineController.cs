using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        // GET: Cuisine
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Search(string name)
        {
            var mess = Server.HtmlEncode(name);
            return Content("This is the Search Action for " + mess);
        }
    }
}