using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gotcha_2._0.Models;

namespace Gotcha_2._0.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // Game controls for player
        public ActionResult GameList()
        {
            List<Game> game = new List<Game>();
            game.Add(new Game() { Id = 12345, Name = "Best game ever" });

            return View(game);
        }
    }
}