﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using Ru.GameSchool.Web.Classes.Interfaces;

namespace Ru.GameSchool.Web.Classes
{
    public class FormsAuthenticationService : IFormsAuthenticationService
    {
        public void SignIn(string userName, bool createPersistentCookie)
        {
            if (String.IsNullOrEmpty(userName)) throw new ArgumentException(@"Value cannot be null or empty.", "userName");

            FormsAuthentication.SetAuthCookie(userName, createPersistentCookie);
        }

        public void SignOut()
        {
            FormsAuthentication.SignOut();
        }
    }
}