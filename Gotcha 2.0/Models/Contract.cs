using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gotcha_2._0.Models
{
    public class Contract
    {
        public int Id { get; set; }
        public DateTime EliminationTime { get; set; }
        public int Eliminations { get; set; }

        // foreign keys
        public int Word_Id { get; set; }
        public int User_Id { get; set; }
        public int Game_Id { get; set; }
    }
}