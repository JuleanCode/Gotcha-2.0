using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gotcha_2._0.Models;
using Dapper;
using System.Data;

namespace Gotcha_2._0.DataAccess
{
    public class UserData
    {
        public List<User> GetUsers()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GotchaDB")))
            {
                return connection.Query<User>("select * from Users").ToList();
            }
        }
    }
}