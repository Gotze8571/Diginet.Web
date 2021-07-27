using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackofficeWireframV2.Extension
{
    public class LoginUserDB
    {
        public LoginUserDB()
        {

        }
        public bool ValidLogin(string UserId, string password, string machineName)
        {
            bool isValidUser = false;
            string userGroup = "Admin";
            int thisUserId = 0;

            // userGroup check from database.
            userGroup = ""; 
            try
            {
                if(userGroup != null)
                {
                    return true;
                }
                // check group of user can be found in the Group in database.

            }
            catch (Exception ex)
            {
                throw;
            }
            return isValidUser;
        }
    }
}