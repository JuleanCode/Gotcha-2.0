using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gotcha_2._0.Models;
using Dapper;
using System.Data;

namespace Gotcha_2._0.DataAccess
{
    public class ContractData
    {
        public List<Contract> GetContracts()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GotchaDB")))
            {
                return connection.Query<Contract>("SELECT * FROM [Contract]").ToList();
            }
        }
        public List<Contract> GetContractsFromGame(int game_Id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GotchaDB")))
            {
                return connection.Query<Contract>("SELECT * FROM [Contract] WHERE Game_Id = @Id", new { Id = game_Id }).ToList();
            }
        }
        public void AddContract(Contract contract)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GotchaDB")))
            {
                string insertQuery = @"INSERT INTO [dbo].[Contract](EliminationTime, Elimination, Word_Id, User_Id, Game_Id) 
                                       VALUES (@EliminationTime, @Elimination, @Word_Id, @User_Id, @Game_Id)";

                var result = connection.Execute(insertQuery, contract);
            }
        }
        public void EditGame(Contract contract)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GotchaDB")))
            {
                string updateQuery = @"UPDATE [dbo].[Contract] SET EliminationTime = @EliminationTime, Elimination = @Elimination, Word_Id = @Word_Id, User_Id = @User_Id, Game_Id = @Game_Id
                                        WHERE Id = @Id";

                var result = connection.Execute(updateQuery, contract);
            }
        }
    }
}