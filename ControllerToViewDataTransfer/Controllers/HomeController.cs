using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllerToViewDataTransfer.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            ViewData["data"] = DateTime.Now.ToString();
            ViewBag.Text = "My Data here";
            TempData["key"] = "tempdata value";
            return View();  //observation -  tempdata is used to persist data upon a request.  When the next request comes, the values disappear and once the tempdata values are used, it is deleted in memory.  There are TempData.Keep and TempData.Peek that comes for survival.
            //return RedirectToAction("Result");
        }

        public ActionResult Result()
        {
            var data = TempData["key"].ToString();
            return Content(data);
        }
	}
}