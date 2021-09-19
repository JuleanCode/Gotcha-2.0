using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gotcha_2._0.Models
{
    public class WordSet
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // foreign keys
        public int Maker_Id { get; set; }
    }
}