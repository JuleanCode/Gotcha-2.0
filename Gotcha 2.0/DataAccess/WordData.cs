using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gotcha_2._0.Models;
using Dapper;
using System.Data;

namespace Gotcha_2._0.DataAccess
{
    public class WordData
    {
        public List<Word> GetWords()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GotchaDB")))
            {
                return connection.Query<Word>("SELECT * FROM [Word]").ToList();
            }
        }
        public Word GetWordFromId(int word_Id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GotchaDB")))
            {
                return connection.QuerySingle<Word>("SELECT * FROM [Word] WHERE Id = @Id", new { Id = word_Id });
            }
        }
        public void AddWord(Word word)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GotchaDB")))
            {
                string insertQuery = @"INSERT INTO [dbo].[Word](Content, Maker_Id) 
                                       VALUES (@Content, @Maker_Id)";

                var result = connection.Execute(insertQuery, word);
            }
        }
        public void EditWord(Word word)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GotchaDB")))
            {
                string updateQuery = @"UPDATE [dbo].[Word] SET Content = @Content, Maker_Id = @Maker_id 
                                        WHERE Id = @Id";

                var result = connection.Execute(updateQuery, word);
            }
        }
        public void DeleteWord(int word_Id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GotchaDB")))
            {
                connection.Execute(@"DELETE FROM [Word] WHERE Id = @Id", new { Id = word_Id });
            }
        }
    }
}