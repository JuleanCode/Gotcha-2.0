using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gotcha_2._0.Models;
using Dapper;
using System.Data;

namespace Gotcha_2._0.DataAccess
{
    public class WordSetData
    {
        public List<WordSet> GetWords()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GotchaDB")))
            {
                return connection.Query<WordSet>("SELECT * FROM [WordSet]").ToList();
            }
        }
        public WordSet GetWordSetFromId(int wordSet_Id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GotchaDB")))
            {
                return connection.QuerySingle<WordSet>("SELECT * FROM [WordSet] WHERE Id = @Id", new { Id = wordSet_Id });
            }
        }
        public void AddWordSet(WordSet wordSet)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GotchaDB")))
            {
                string insertQuery = @"INSERT INTO [dbo].[WordSet](Name, Maker_Id) 
                                       VALUES (@Name, @Maker_Id)";

                var result = connection.Execute(insertQuery, wordSet);
            }
        }
        public void EditWordSet(WordSet wordSet)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GotchaDB")))
            {
                string updateQuery = @"UPDATE [dbo].[WordSet] SET Name = @Name, Maker_Id = @Maker_id 
                                        WHERE Id = @Id";

                var result = connection.Execute(updateQuery, wordSet);
            }
        }
        public void DeleteWordSet(int wordSet_Id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GotchaDB")))
            {
                connection.Execute(@"DELETE FROM [WordSet] WHERE Id = @Id", new { Id = wordSet_Id });
            }
        }
    }
}