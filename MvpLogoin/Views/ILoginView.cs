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
using MvpLogoin.Bean;

namespace MvpLogoin.Views
{
    public interface ILoginView
    {
        String GetUserName();
        String GetPassword();
        void ShowLoading();

        void HideLoading();
        void ToMainActivity(User user);
        void ShowFailed();
        void ShowError();
    }
}