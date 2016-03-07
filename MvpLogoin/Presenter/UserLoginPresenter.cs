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
using MvpLogoin.Model;
using MvpLogoin.Views;
using MvpLogoin.Model.Impl;
using MvpLogoin.Bean;
using MvpLogoin.Model.Interface;
using MvpLogoin.Model.Listener;

namespace MvpLogoin.Presenter
{
    public class UserLoginPresenter:OnLoginListener
    {
        private IUser User;
        private ILoginView userLoginView;
        private Handler mHandler = new Handler();
        public UserLoginPresenter(ILoginView userLoginView,Context context)
        {
            this.userLoginView = userLoginView;
            this.User = new UserImpl(context);
        }
        public void Login()
        {
            userLoginView.ShowLoading();
            User.Login(userLoginView.GetUserName(), userLoginView.GetPassword(), this);
        }

        public void LoginSuccess(User user)
        {
            mHandler.Post(() =>
            {
                userLoginView.ToMainActivity(user);
                userLoginView.HideLoading();
            });
        }

        public void LoginFailed()
        {
            mHandler.Post(() =>
            {
                userLoginView.ShowFailed();
                userLoginView.HideLoading();
            });
        }

        public void LoginError()
        {
            mHandler.Post(() =>
            {
                userLoginView.ShowError();
                userLoginView.HideLoading();
            });
        }
    }
}