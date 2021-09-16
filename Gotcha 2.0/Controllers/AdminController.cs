using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gotcha_2._0.Models;

namespace Gotcha_2._0.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            Session["CurentUserRol"] = "Admin";
            return View();


        }

        // User controls for admin
        public ActionResult UserList()
        {
            List<User> user = new List<User>();

            user.Add(new User() { Id = 12345, Email = "Admin@gmail.com", FirstName = "Admin", LastName = "Admin", Password = "P@ssw0rd", Rol= 1, Active= true});

            return View(user);
        }
        public ActionResult UserAdd()
        {
            return View();
        }
        public ActionResult UserEdit()
        {
            return View();
        }
        public ActionResult UserDelete()
        {
            return View();
        }
    }
}