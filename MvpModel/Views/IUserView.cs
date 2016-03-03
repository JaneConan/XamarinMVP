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

namespace MvpModel.Views
{
    public interface IUserView
    {
        int GetID();

        String GetFristName();

        String GetLastName();

        void SetFirstName(String firstName);

        void SetLastName(String lastName);
    }

}