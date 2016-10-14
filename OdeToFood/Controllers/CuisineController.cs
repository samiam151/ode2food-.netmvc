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

        [HttpPost]
        public ActionResult Search(string name = "french")
        {
            var message = Server.HtmlEncode(name);
            //return Content("This is the Search Action for " + mess);
            //return RedirectToAction("Index", "Home", new { name = name });
            //return RedirectToRoute("Default", new { controller = "Home", action = "Index" });
            //return File(Server.MapPath("~/Content/site.css"), "text.css");
            return Json(new { Message = message, Name = "Nick" }, JsonRequestBehavior.AllowGet);

        }

        [HttpGet]
        public ActionResult Search()
        {
            return Json(new { Message = message, Name = "Nick" }, JsonRequestBehavior.AllowGet);
        }
    }
}