using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gotcha_2._0.Models;
using Dapper;
using System.Data;


namespace Gotcha_2._0.DataAccess
{
    public class GameTypeData
    {
        public List<GameType> GetGameType()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GotchaDB")))
            {
                return connection.Query<GameType>("SELECT * FROM [GameType]").ToList();
            }
        }
        public GameType GetGameTypeFromId(int gameType_Id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GotchaDB")))
            {
                return connection.QuerySingle<GameType>("SELECT * FROM [GameType] WHERE Id = @Id", new { Id = gameType_Id });
            }
        }
        public void AddGameType(GameType gameType)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GotchaDB")))
            {
                string insertQuery = @"INSERT INTO [dbo].[GameType](Name, Description, Maker_Id) 
                                       VALUES (@Name, @Description, @Maker_Id)";

                var result = connection.Execute(insertQuery, gameType);
            }
        }
        public void EditGameType(GameType gameType)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GotchaDB")))
            {
                string updateQuery = @"UPDATE [dbo].[GameType] SET Name = @Name, Description = @Description, Maker_Id = @Maker_Id 
                                        WHERE Id = @Id";

                var result = connection.Execute(updateQuery, gameType);
            }
        }
        public void DeleteGameType(int gameType_Id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GotchaDB")))
            {
                connection.Execute(@"DELETE FROM [GameType] WHERE Id = @Id", new { Id = gameType_Id });
            }
        }
    }
}