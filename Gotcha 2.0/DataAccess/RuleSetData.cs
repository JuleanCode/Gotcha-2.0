using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gotcha_2._0.Models;
using Dapper;
using System.Data;

namespace Gotcha_2._0.DataAccess
{
    public class RuleSetData
    {
        public List<RuleSet> GetRuleSets()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GotchaDB")))
            {
                return connection.Query<RuleSet>("SELECT * FROM [RuleSet]").ToList();
            }
        }
        public RuleSet GetRuleSetFromId(int ruleSet_Id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GotchaDB")))
            {
                return connection.QuerySingle<RuleSet>("SELECT * FROM [RuleSet] WHERE Id = @Id", new { Id = ruleSet_Id });
            }
        }
        public void AddRuleSet(RuleSet ruleSet)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GotchaDB")))
            {
                string insertQuery = @"INSERT INTO [dbo].[RuleSet](Name, Maker_Id) 
                                       VALUES (@Name, @Maker_Id)";

                var result = connection.Execute(insertQuery, ruleSet);
            }
        }
        public void EditRuleSet(RuleSet ruleSet)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GotchaDB")))
            {
                string updateQuery = @"UPDATE [dbo].[RuleSet] SET Name = @Name, Maker_Id = @Maker_id 
                                        WHERE Id = @Id";

                var result = connection.Execute(updateQuery, ruleSet);
            }
        }
        public void DeleteRuleSet(int rule_Id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GotchaDB")))
            {
                connection.Execute(@"DELETE FROM [RuleSet] WHERE Id = @Id", new { Id = rule_Id });
            }
        }
    }
}