using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lyrics.com.Models.Login;

namespace Lyrics.com.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(UserModel userModel)
        {
            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(UserModel userModel)
        {
            LoginBusinessLogics loginBusinessLogics = new LoginBusinessLogics();
            loginBusinessLogics.SaveCustomer(userModel);
            return View();
        }

        [HttpGet]
        public ActionResult ViewData(int Id)
        {
            LoginBusinessLogics loginBusinessLogics = new LoginBusinessLogics();
            List<UserModel> listuser = loginBusinessLogics.GetCustomer(Id);
            return View(listuser);
        }
    }
}