using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace P_NUnit.PageElements
{
    public class Elements
    {

        #region "Login Page"
        //Short name of login Page  : L
        public static By  L_UserName { get 
            { 
                return By.Id("email"); 
            }
        }

        public static By L_Password
        {
            get
            {
                return By.Id("password");
            }
        }

        public static By L_Submit
        {
            get
            {
                return By.Id("submit_Pass");
            }
        }

        #endregion

    }
}
