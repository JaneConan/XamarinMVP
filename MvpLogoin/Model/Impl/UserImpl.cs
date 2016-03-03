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
using System.Threading.Tasks;
using NSACL.Net;
using MvpLogoin.Model.Net;
using MvpLogoin.Model.Mod;
using MvpLogoin.Bean;

namespace MvpLogoin.Model.Impl
{
    public class UserImpl : UserNet, IUser
    {
        public UserImpl(Context context) : base(context) { }
        public void Login(string username, string password, OnLoginListener loginListener)
        {
            Task.Factory.StartNew(() =>
            {
                PullDownResult isOk;
                try
                {
                    isOk = UserLogin(username, password);
                    if (isOk.Type == ResultType.Success)
                    {
                        User user = new User();
                        user.SetUserRole(isOk.ErrorMsg);
                        loginListener.LoginSuccess(user);
                    }
                    else
                    {
                        loginListener.LoginFailed();
                    }
                }
                catch (Exception e)
                {
                    loginListener.LoginError();
                }
            });

        }
    }
}