using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gotcha_2._0.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Rol { get; set; }
        public bool Active { get; set; }
    }
}