using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gotcha_2._0.Models;
using Gotcha_2._0.DataAccess;

namespace Gotcha_2._0.Controllers
{
    public class HomeController : Controller
    {
        UserData UserDB = new UserData();
        List<User> users = new List<User>();
        User user = new User();

        public ActionResult Index()
        {
            Session["CurentUserRol"] = 0;
            return RedirectToAction("Login");
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {

            User curentUser = UserDB.GetUserFromName(user);

            Session["CurentUserRol"] = curentUser.Rol;
            Session["CurentUser_Id"] = curentUser.Id;

            if (Session["CurentUserRol"].ToString() == "1")
            {
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return RedirectToAction("GameList", "Player");
            }
            
        }
    }
}