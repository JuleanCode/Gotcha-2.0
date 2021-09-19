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
        List<User> users = new List<User>();
        User user = new User();

        List<GameType> gameTypes = new List<GameType>();
        GameType gameType = new GameType();

        List<Word> words = new List<Word>();
        Word word = new Word();

        List<WordSet> wordSets = new List<WordSet>();
        WordSet wordSet = new WordSet();

        List<Rule> rules = new List<Rule>();
        Rule rule = new Rule();

        List<RuleSet> ruleSets = new List<RuleSet>();
        RuleSet ruleSet = new RuleSet();

        List<Game> games = new List<Game>();
        Game game = new Game();

        // GET: Admin
        public ActionResult Index()
        {
            Session["CurentUserRol"] = "Admin";
            return View();
        }

        // User controllers for admin
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

        // GameType controllers for admin
        public ActionResult GameTypeList()
        {
            return View();
        }
        public ActionResult GameTypeAdd()
        {
            return View();
        }
        public ActionResult GameTypeEdit()
        {
            return View();
        }
        public ActionResult GameTypeDelete()
        {
            return View();
        }

        // Word controllers for admin
        public ActionResult WordList()
        {
            return View();
        }
        public ActionResult WordAdd()
        {
            return View();
        }
        public ActionResult WordEdit()
        {
            return View();
        }
        public ActionResult WordDelete()
        {
            return View();
        }

        // WordSet controllers for admin
        public ActionResult WordSetList()
        {
            return View();
        }
        public ActionResult WordSetAdd()
        {
            return View();
        }
        public ActionResult WordSetEdit()
        {
            return View();
        }
        public ActionResult WordSetDelete()
        {
            return View();
        }

        // Rule controllers for admin
        public ActionResult RuleList()
        {
            return View();
        }
        public ActionResult RuleAdd()
        {
            return View();
        }
        public ActionResult RuleEdit()
        {
            return View();
        }
        public ActionResult RuleDelete()
        {
            return View();
        }

        // RuleSet controllers for admin
        public ActionResult RuleSetList()
        {
            return View();
        }
        public ActionResult RuleSetAdd()
        {
            return View();
        }
        public ActionResult RuleSetEdit()
        {
            return View();
        }
        public ActionResult RuleSetDelete()
        {
            return View();
        }

        // Game controllers for admin
        public ActionResult GameList()
        {
            return View();
        }
        public ActionResult GameAdd()
        {
            return View();
        }
        public ActionResult GameEdit()
        {
            return View();
        }
        public ActionResult GameDelete()
        {
            return View();
        }
    }
}