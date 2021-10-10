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
                return connection.Query<User>("SELECT * FROM [Users]").ToList();
            }
        }
        public User GetUserFromId(int user_Id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GotchaDB")))
            {
                return connection.QuerySingle<User>("SELECT * FROM [Users] WHERE Id = @Id", new { Id = user_Id });
            }
        }
        public User GetUserFromName(User user)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GotchaDB")))
            {
                return connection.QuerySingle<User>("SELECT * FROM [Users] WHERE Email = @Email", new { Email = user.Email });
            }
        }
        public void AddUser(User user)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GotchaDB")))
            {
                string insertQuery = @"INSERT INTO [dbo].[Users](Email, Password, FirstName, LastName, Rol, Active) 
                                       VALUES (@Email, @Password, @FirstName, @LastName, @Rol, @Active)";

                var result = connection.Execute(insertQuery, user);
            }
        }
        public void EditUser(User user)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GotchaDB")))
            {
                string updateQuery = @"UPDATE [dbo].[Users] SET Email = @Email, Password = @Password, FirstName = @FirstName, LastName = @LastName, Rol = @Rol, Active = @Active 
                                        WHERE Id = @Id";                     

                var result = connection.Execute(updateQuery, user);
            }
        }
        public void DeleteUser(int user_Id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GotchaDB")))
            {
                connection.Execute(@"DELETE FROM [Users] WHERE Id = @Id", new { Id = user_Id });
            }
        }
    }
}