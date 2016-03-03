using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using MvpModel.Presenter;
using MvpModel.Views;

namespace MvpModel
{
    [Activity(Label = "MvpModel", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity, IUserView, View.IOnClickListener
    {
        UserPresenter presenter;
        EditText id, first, last;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
             FindViewById<Button>(Resource.Id.save).SetOnClickListener(this);
             FindViewById<Button>(Resource.Id.load).SetOnClickListener(this); ;
            
            id = FindViewById<EditText>(Resource.Id.id);
            first = FindViewById<EditText>(Resource.Id.first);
            last = FindViewById<EditText>(Resource.Id.last);
            presenter = new UserPresenter(this);
        }

        public int GetID()
        {
            return Convert.ToInt32(id.Text.ToString());
        }

        public string GetFristName()
        {
            return first.Text.ToString();
        }

        public string GetLastName()
        {
            return last.Text.ToString();
        }

        public void SetFirstName(string firstName)
        {
            first.Text = firstName;
        }

        public void SetLastName(string lastName)
        {
            last.Text = lastName;
        }

        public void OnClick(View v)
        {
            switch (v.Id)
            {
                case Resource.Id.save:
                    presenter.SaveUser(GetID(), GetFristName(), GetLastName());
                    break;
                case Resource.Id.load:
                    presenter.LoadUser(GetID());
                    break;
            }
        }
    }
}

