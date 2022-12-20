using Assignment1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment1.Services.Data
{
    public class SecurityDAO
    {
        internal bool FindByUser(UserModel user)
        {
            //if (user.Username== "Admin" && user.Password== "Secret")
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            return (user.Username == "Admin" && user.Password == "Secret");
        }
    }
}