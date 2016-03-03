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

namespace MvpModel.Bean
{
    public class UserBean
    {
        public String mFirstName { get; set; }
        public String mLastName { get; set; }

        public UserBean(String firstName, String lastName)
        {
            this.mFirstName = firstName;
            this.mLastName = lastName;
        }
    }
}