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
using MvpModel.Views;
using MvpModel.Bean;
using MvpModel.Model;
using MvpModel.Model.Impl;

namespace MvpModel.Presenter
{
    public class UserPresenter
    {
        private IUserView mUserView;
        private IUserModel mUserModel;

        public UserPresenter(IUserView view)
        {
            mUserView = view;
            mUserModel = new UserModel();
        }

        public void SaveUser(int id, String firstName, String lastName)
        {
            mUserModel.SetID(id);
            mUserModel.SetFirstName(firstName);
            mUserModel.SetLastName(lastName);
        }

        public void LoadUser(int id)
        {
            UserBean user = mUserModel.Load(id);
            mUserView.SetFirstName(user.mFirstName); // 通过调用IUserView的方法来更新显示
            mUserView.SetLastName(user.mLastName);
        }
    }

}