using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gotcha_2._0.Models;
using Dapper;
using System.Data;

namespace Gotcha_2._0.DataAccess
{
    public class GameData
    {
        public List<Game> GetGames()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GotchaDB")))
            {
                return connection.Query<Game>("SELECT * FROM [Game]").ToList();
            }
        }
        public Game GetGameFromId(int game_Id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GotchaDB")))
            {
                return connection.QuerySingle<Game>("SELECT * FROM [Game] WHERE Id = @Id", new { Id = game_Id });
            }
        }
        public void AddGame(Game game)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GotchaDB")))
            {
                string insertQuery = @"INSERT INTO [dbo].[Game](Name, StartTime, EndTime, Location, Archived, Rating, Maker_Id, RandomWinner, BestKill, RuleSet_Id, GameType_Id, WordSet_Id) 
                                       VALUES (@Name, @StartTime, @EndTime, @Location, @Archived, @Rating, @Maker_Id, @RandomWinner, @BestKill, @RuleSet_Id, @GameType_Id, @WordSet_Id)";

                var result = connection.Execute(insertQuery, game);
            }
        }
        public void EditGame(Game game)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GotchaDB")))
            {
                string updateQuery = @"UPDATE [dbo].[Game] SET Name = @Name, StartTime = @StartTime EndTime = @EndTime, Location = @Location, Archive = @Archived, Rating = @Rating, MakerId = @MakerId, RandomWinner = @RandomWinner, BestKill = @BestKill, RuleSet_Id = @RuleSet_Id, GameType_Id = @GameType_Id, WordSet_Id = @WordSet_Id 
                                        WHERE Id = @Id";

                var result = connection.Execute(updateQuery, game);
            }
        }
        public void DeleteGame(int game_Id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GotchaDB")))
            {
                connection.Execute(@"DELETE FROM [Game] WHERE Id = @Id", new { Id = game_Id });
            }
        }
    }
}