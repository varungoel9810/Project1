﻿using Assignment1.Models;
using Assignment1.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment1.Services.Business
{
    public class SecurityService
    {
        SecurityDAO daoService = new SecurityDAO();

        public bool Authenticate(UserModel user)
        {
            return daoService.FindByUser(user);
        }
    
    
    }


}