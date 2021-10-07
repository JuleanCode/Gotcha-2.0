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
        public void AddContract(Contract contract)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GotchaDB")))
            {
                string insertQuery = @"INSERT INTO [dbo].[Contract](EliminationTime, Eliminations, Word_Id, User_Id, Game_Id) 
                                       VALUES (@EliminationTime, @Eliminations, @Word_Id, @User_Id, @Game_Id)";

                var result = connection.Execute(insertQuery, contract);
            }
        }
    }
}