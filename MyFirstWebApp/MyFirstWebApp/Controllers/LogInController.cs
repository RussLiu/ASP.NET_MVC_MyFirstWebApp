using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyFirstWebApp.Models;

namespace MyFirstWebApp.Controllers
{
    public class LogInController : Controller
    {
        // GET: LogIn
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Verify(LoginViewModel vm)
        {
            ViewBag.Account = vm.Account;
            ViewBag.Password = vm.Password;
            return View();
        }
        /*
        public ActionResult Verify(string account, string password)
        {
            ViewBag.Account = account;
            ViewBag.Password = password;
            return View();
        }
        public ActionResult Verify(FormCollection obj)
        {
            ViewBag.Account = obj["account"];
            ViewBag.Password = obj["password"];


            return View();
        }
        */

    }
}