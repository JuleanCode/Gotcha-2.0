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
        UserData UserDB = new UserData();
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
            users = UserDB.GetUsers();

            return View(users);
        }
        public ActionResult UserAdd()
        {
            return View();
        }
        public ActionResult UserEdit(int Id)
        {
            return View(UserDB.GetUserFromId(Id));
        }
        public ActionResult UserDelete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UserAdd(User user)
        {
            UserDB.AddUser(user);

            return RedirectToAction("UserList");
        }
        [HttpPost]
        public ActionResult UserEdit(User user)
        {
            UserDB.EditUser(user);

            return RedirectToAction("UserList");
        }
        [HttpPost]
        public ActionResult UserDelete(int Id)
        {
            UserDB.DeleteUser(Id);

            return RedirectToAction("UserList");
        }

        // GameType controllers for admin
        public ActionResult GameTypeList()
        {
            gameTypes.Add(new GameType { Id = 123, Name = "gameType", Description = "gameType" });

            return View(gameTypes);
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
            words.Add(new Word { Id = 123, Content = "John Doe" });

            return View(words);
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
            wordSets.Add(new WordSet { Id = 123, Name = "John Doe" });

            return View(wordSets);
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
            rules.Add(new Rule { Id = 123, Name = "John Doe", Description = "John Doe" });

            return View(rules);
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
            ruleSets.Add(new RuleSet { Id = 123, Name = "John Doe" });

            return View(ruleSets);
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
            games.Add(new Game { Id = 123, Name = "John Doe", StartTime = new DateTime(2015, 12, 25), EndTime = new DateTime(2016, 12, 25), Location = "John Doe", Archived = false, Rating = 5 });

            return View(games);
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