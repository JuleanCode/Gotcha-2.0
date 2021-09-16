using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gotcha_2._0.Models
{
    public class Rule
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int Description { get; set; }

        // foreign keys
        public int Maker_Id { get; set; }
    }
}