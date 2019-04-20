using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lyrics.com.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //[Authorize]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Album()
        {
            return View();
        }
        public ActionResult Events()
        {
            return View();
        }
        public ActionResult News()
        {
            return View();

        }
        public ActionResult Contact()
        {
            return View();

        }
    }
}