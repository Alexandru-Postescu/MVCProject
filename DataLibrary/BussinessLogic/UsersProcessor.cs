using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.Models;
using DataLibrary.DataAccess;

namespace DataLibrary.BusinessLogic
// used to save and load data for Users table
{
    public static class UsersProcessor
    {
        public static int CreateUsers(int usersid, string firmname, string location, string emailadress, string phonenumber)
        {
            UsersModel data = new UsersModel
            {
                UsersId = usersid,
                Firmname = firmname,
                EmailAdress = emailadress,
                PhoneNumber = phonenumber,
                Location = location

            };
            string sql = @"insert into dbo.Users (UsersId, FirmName, Location, Email, PhoneNumber) 
                           values (@UsersId, @FirmName, @Location, @EmailAdress, @PhoneNumber);";
            return SqlDataAccess.SaveData(sql, data);
        }
        public static List<UsersModel> LoadUsers()
        {
            string sql = "select UserId, FirmName, Location, Email, PhoneNumber " +
                         "from dbo.Users;";
            return SqlDataAccess.LoadData<UsersModel>(sql);





        }
    }
}
