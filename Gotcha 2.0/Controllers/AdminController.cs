using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gotcha_2._0.Models;
using Gotcha_2._0.DataAccess;

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

        List<User> users = new List<User>();
        public ActionResult UserList()
        {
            UserData db = new UserData();

            users = db.GetUsers();

            return View(users);
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