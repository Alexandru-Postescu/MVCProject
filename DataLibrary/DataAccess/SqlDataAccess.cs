using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace DataLibrary.DataAccess
    // is used like a template for saving and loading data from different tables
{   // you will need Dapper nuget package
    // look for a version that works with your .NET FRAMEWORK 

    public class SqlDataAccess
    {
        // method to get the connection string
        public static string GetConnectionString(string connectionName = "MVCDatabase")
        {

            return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;

        }
        /*
         * T represents the model i want to load
         * sql can represent a store procedure or a sequal -> load query into type T 
         * 
         */
        public static List<T> LoadData<T>(string sql)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Query<T>(sql).ToList();
            }
        }
        // return the number of records affected by the query on the model T
        public static int SaveData<T>(string sql, T data)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Execute(sql, data);
            }

        }
    }
}
