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

        GameTypeData GameTypeDB = new GameTypeData();
        List<GameType> gameTypes = new List<GameType>();
        GameType gameType = new GameType();

        WordData WordDB = new WordData();
        List<Word> words = new List<Word>();
        Word word = new Word();

        WordSetData WordSetDB = new WordSetData();
        List<WordSet> wordSets = new List<WordSet>();
        WordSet wordSet = new WordSet();

        RuleData RuleDB = new RuleData();
        List<Rule> rules = new List<Rule>();
        Rule rule = new Rule();

        RuleSetData RuleSetDB = new RuleSetData();
        List<RuleSet> ruleSets = new List<RuleSet>();
        RuleSet ruleSet = new RuleSet();

        GameData GameDB = new GameData();
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
            gameTypes = GameTypeDB.GetGameType();

            return View(gameTypes);
        }
        public ActionResult GameTypeAdd()
        {
            return View();
        }
        public ActionResult GameTypeEdit(int id)
        {
            return View(GameTypeDB.GetGameTypeFromId(id));
        }
        public ActionResult GameTypeDelete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GameTypeAdd(GameType gameType)
        {
            GameTypeDB.AddGameType(gameType);

            return RedirectToAction("GameTypeList");
        }
        [HttpPost]
        public ActionResult GameTypeEdit(GameType gameType)
        {
            GameTypeDB.EditGameType(gameType);

            return RedirectToAction("GameTypeList");
        }
        [HttpPost]
        public ActionResult GameTypeDelete(int Id)
        {
            GameTypeDB.DeleteGameType(Id);

            return RedirectToAction("GameTypeList");
        }

        // Word controllers for admin
        public ActionResult WordList()
        {
            words = WordDB.GetWords();

            return View(words);
        }
        public ActionResult WordAdd()
        {
            return View();
        }
        public ActionResult WordEdit(int id)
        {
            return View(WordDB.GetWordFromId(id));
        }
        public ActionResult WordDelete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult WordAdd(Word word)
        {
            WordDB.AddWord(word);

            return RedirectToAction("WordList");
        }
        [HttpPost]
        public ActionResult WordEdit(Word word)
        {
            WordDB.EditWord(word);

            return RedirectToAction("WordList");
        }
        [HttpPost]
        public ActionResult WordDelete(int Id)
        {
            WordDB.DeleteWord(Id);

            return RedirectToAction("WordList");
        }

        // WordSet controllers for admin
        public ActionResult WordSetList()
        {
            wordSets = WordSetDB.GetWordSets();

            return View(wordSets);
        }
        public ActionResult WordSetAdd()
        {
            return View();
        }
        public ActionResult WordSetEdit(int id)
        {
            return View(WordSetDB.GetWordSetFromId(id));
        }
        public ActionResult WordSetDelete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult WordSetAdd(WordSet wordSet)
        {
            WordSetDB.AddWordSet(wordSet);

            return RedirectToAction("WordSetList");
        }
        [HttpPost]
        public ActionResult WordSetEdit(WordSet wordSet)
        {
            WordSetDB.EditWordSet(wordSet);

            return RedirectToAction("WordSetList");
        }
        [HttpPost]
        public ActionResult WordSetDelete(int Id)
        {
            WordSetDB.DeleteWordSet(Id);

            return RedirectToAction("WordSetList");
        }

        // Rule controllers for admin
        public ActionResult RuleList()
        {
            rules = RuleDB.GetRules();

            return View(rules);
        }
        public ActionResult RuleAdd()
        {
            return View();
        }
        public ActionResult RuleEdit(int id)
        {
            return View(RuleDB.GetRuleFromId(id));
        }
        public ActionResult RuleDelete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RuleAdd(Rule rule)
        {
            RuleDB.AddRule(rule);

            return RedirectToAction("RuleList");
        }
        [HttpPost]
        public ActionResult RuleEdit(Rule rule)
        {
            RuleDB.EditRule(rule);

            return RedirectToAction("RuleList");
        }
        [HttpPost]
        public ActionResult RuleDelete(int Id)
        {
            RuleDB.DeleteRule(Id);

            return RedirectToAction("RuleList");
        }

        // RuleSet controllers for admin
        public ActionResult RuleSetList()
        {
            ruleSets = RuleSetDB.GetRuleSets();

            return View(ruleSets);
        }
        public ActionResult RuleSetAdd()
        {
            return View();
        }
        public ActionResult RuleSetEdit(int id)
        {
            return View(RuleSetDB.GetRuleSetFromId(id));
        }
        public ActionResult RuleSetDelete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RuleSetAdd(RuleSet ruleSet)
        {
            RuleSetDB.AddRuleSet(ruleSet);

            return RedirectToAction("RuleSetList");
        }
        [HttpPost]
        public ActionResult RuleSetEdit(RuleSet ruleSet)
        {
            RuleSetDB.EditRuleSet(ruleSet);

            return RedirectToAction("RuleSetList");
        }
        [HttpPost]
        public ActionResult RuleSetDelete(int Id)
        {
            RuleSetDB.DeleteRuleSet(Id);

            return RedirectToAction("RuleSetList");
        }

        // Game controllers for admin
        public ActionResult GameList()
        {
            games = GameDB.GetGames();

            return View(games);
        }
        public ActionResult GameAdd()
        {
            return View();
        }
        public ActionResult GameEdit(int id)
        {
            return View(GameDB.GetGameFromId(id));
        }
        public ActionResult GameDelete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GameAdd(Game game)
        {
            GameDB.AddGame(game);

            return RedirectToAction("GameList");
        }
        [HttpPost]
        public ActionResult GameEdit(Game game)
        {
            GameDB.EditGame(game);

            return RedirectToAction("GameList");
        }
        [HttpPost]
        public ActionResult GameDelete(int Id)
        {
            GameDB.DeleteGame(Id);

            return RedirectToAction("GameList");
        }
    }
}