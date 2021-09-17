using Gotcha_2._0.DataAccess;
using Gotcha_2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gotcha_2._0.Controllers
{
    public class PlayerController : Controller
    {
        // GET: Player
        public ActionResult Index()
        {
            return View();
        }

        List<Game> games = new List<Game>();
        public ActionResult GameList()
        {
            return View(games);
        }
    }
}