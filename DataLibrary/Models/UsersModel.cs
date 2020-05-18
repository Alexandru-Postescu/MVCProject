using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* We not going to create a password method; we don't store the password in the database
 * 
 */
namespace DataLibrary.Models
{
    public class UsersModel
    {
        public int UsersId { get; set; }
        public string Username { get; set; }
        public string Firmname { get; set; }
        public string EmailAdress { get; set; }
        public string PhoneNumber { get; set; }
        public string Location { get; set; }


    }
}
