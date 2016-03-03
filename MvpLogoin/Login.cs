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
using Android.Support.V7.App;
using MvpLogoin.Views;
using MvpLogoin.Bean;
using MvpLogoin.Model;
using MvpLogoin.Presenter;

namespace MvpLogoin
{
    [Activity(Label = "Login", MainLauncher = true, Icon = "@drawable/icon")]
    public class Login : Activity, ILoginView
    {
        private EditText mEtUsername, mEtPassword;
        private Button mBtnLogin;
        protected ProgressDialog LoginDialog;
        private UserLoginPresenter mUserLoginPresenter;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Login);
            mUserLoginPresenter = new UserLoginPresenter(this, this);
            if (LoginDialog == null)
            {
                LoginDialog = new ProgressDialog(this);
                LoginDialog.SetMessage("µÇÂ¼ÖÐ...");
                LoginDialog.Indeterminate = true;
                LoginDialog.SetCancelable(false);
            }
            InitViews();
        }
        private void InitViews()
        {
            mEtUsername = FindViewById<EditText>(Resource.Id.username);
            mEtPassword = FindViewById<EditText>(Resource.Id.password);

            mBtnLogin = FindViewById<Button>(Resource.Id.login);
            mBtnLogin.Click += MBtnLogin_Click;
        }

        private void MBtnLogin_Click(object sender, EventArgs e)
        {
            mUserLoginPresenter.Login();
        }

        public string GetPassword()
        {
            return mEtPassword.Text.ToString();
        }
        public string GetUserName()
        {
            return mEtUsername.Text.ToString();
        }
        public void HideLoading()
        {
            LoginDialog.Dismiss();
        }
        public void ShowLoading()
        {
            LoginDialog.Show();
        }
        public void ToMainActivity(User user)
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            intent.PutExtra("user", user.GetUserRole());
            StartActivity(intent);
        }
        public void ShowFailed()
        {
            Toast.MakeText(this, "ÃÜÂë´íÎó", ToastLength.Short).Show();
        }
        public void ShowError()
        {
            Toast.MakeText(this, "µÇÂ¼Ê§°Ü", ToastLength.Short).Show();
        }
    }
}