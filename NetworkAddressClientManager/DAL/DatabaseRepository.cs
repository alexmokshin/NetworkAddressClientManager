using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NetworkAddressClientManager.Models;
using System.Data.SQLite;

namespace NetworkAddressClientManager.DAL
{
    public class DatabaseRepository
    {

        public static string GetConnectionString()
        {
            IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                .SetBasePath(Environment.CurrentDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            return $@"{Environment.CurrentDirectory}\{configurationRoot.GetConnectionString("DefaultDatabase")}";
        }

        public static SQLiteConnection SimpleDbConnection()
        {
            return new SQLiteConnection("Data Source=" + GetConnectionString());
        }

        public List<Models.User> GetUsers()
        {
            
            List<Models.User> users = new List<User>();
            using (IDbConnection dbConnection = SimpleDbConnection())
            {
                dbConnection.Open();
                users = dbConnection.Query<Models.User>("Select * from Users").ToList();
            }

            return users;
        }


    }
}
