using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gotcha_2._0.Models;
using Gotcha_2._0.DataAccess;

namespace Gotcha_2._0.Controllers
{
    public class PlayerController : Controller
    {
        GameData GameDB = new GameData();
        List<Game> games = new List<Game>();
        Game game = new Game();

        ContractData ContractDB = new ContractData();
        List<Contract> contracts = new List<Contract>();
        Contract contract = new Contract();

        // GET: Player
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult GameList()
        {
            games = GameDB.GetGames();

            return View(games);
        }

        public ActionResult GameJoin(int id)
        {
            contract.Game_Id = id;
            contract.User_Id = Convert.ToInt32(Session["CurentUser_Id"]);
            contract.EliminationTime = DateTime.Now;
            contract.Word_Id = 1;

            ContractDB.AddContract(contract);

            return RedirectToAction("GameList", "Player");
        }
    }
}