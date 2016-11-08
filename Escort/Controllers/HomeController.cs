using Escort.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Escort.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult LoginPage()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
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



        // Admin login from here

        public ActionResult AdminLogin()
        {
            return View();
        }
        public ActionResult AdminManage(string q , int p=1)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                List<AccountList> AccountList = db.Users.Where(t => t.Email != "haovtit@gmail.com").OrderByDescending(t => t.LastLogin).Skip(0).Take(15).Select(t => new AccountList
                {
                    Id = t.Id,
                    UserName = t.UserName,
                    LastLogin = t.LastLogin,
                    Email = t.Email,
                    FullName = t.FullName,
                    Contact = t.Contact,
                    IsDisabled = t.IsDisabled,
                    IsLocked = t.IsLocked
                }).ToList();
                return View(AccountList);
            }
           
        }

      


    }
}