using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gotcha_2._0.Models;
using Dapper;
using System.Data;

namespace Gotcha_2._0.DataAccess
{
    public class RuleData
    {
        public List<Models.Rule> GetRules()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GotchaDB")))
            {
                return connection.Query<Models.Rule>("SELECT * FROM [Rule]").ToList();
            }
        }
        public Models.Rule GetRuleFromId(int rule_Id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GotchaDB")))
            {
                return connection.QuerySingle<Models.Rule>("SELECT * FROM [Rule] WHERE Id = @Id", new { Id = rule_Id });
            }
        }
        public void AddRule(Models.Rule rule)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GotchaDB")))
            {
                string insertQuery = @"INSERT INTO [dbo].[Rule](Name, Description, Maker_Id) 
                                       VALUES (@Name, @Description, @Maker_Id)";

                var result = connection.Execute(insertQuery, rule);
            }
        }
        public void EditRule(Models.Rule rule)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GotchaDB")))
            {
                string updateQuery = @"UPDATE [dbo].[Rule] SET Name = @Name, Description = @Description, Maker_Id = @Maker_id 
                                        WHERE Id = @Id";

                var result = connection.Execute(updateQuery, rule);
            }
        }
        public void DeleteRule(int rule_Id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GotchaDB")))
            {
                connection.Execute(@"DELETE FROM [Rile] WHERE Id = @Id", new { Id = rule_Id });
            }
        }
    }
}