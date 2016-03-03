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
using MvpLogoin.Model.Impl;
using MvpLogoin.Model.Mod;

namespace MvpLogoin.Model.Net
{
    public class UserNet : BaseNet
    {
        public UserNet(Context context) : base(context) { }

        public PullDownResult UserLogin(string UserName, string Password)
        {
            Http.TimeOut = 5000;
            String BaseUrl = GetUrl(Resource.String.Login);
            return Http.PostJson<LoginIn, PullDownResult>(BaseUrl, new LoginIn() { UserName = UserName, PassWord = Password });
        }
    }
}