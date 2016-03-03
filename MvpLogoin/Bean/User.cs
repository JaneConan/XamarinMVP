using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MvpLogoin.Bean
{
    public class User
    {
        private String Username;
        private String Password;
        private String UserRole;
        public String GetUsername()
        {
            return Username;
        }

        public void SetUsername(String username)
        {
            this.Username = username;
        }
        public void SetUserRole(String userRole)
        {
            this.UserRole = userRole;
        }
        public String GetUserRole()
        {
            return UserRole;
        }
        public String GetPassword()
        {
            return Password;
        }

        public void SetPassword(String password)
        {
            this.Password = password;
        }
    }
}