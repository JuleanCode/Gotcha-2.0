using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gotcha_2._0.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Location { get; set; }
        public bool Archived { get; set; }
        public int Rating { get; set; }

        // foreign keys
        public int Maker_Id { get; set; }
        public int RandomWinner { get; set; }
        public int BestKill { get; set; }
        public int RuleSet_Id { get; set; }
        public int GameType_Id { get; set; }
        public int WordSet_Id { get; set; }
    }
}