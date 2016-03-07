using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using MvpLogoin.Presenter;
using MvpLogoin.Views;
using MvpLogoin.Model.Impl;
using System.Collections.Generic;

namespace MvpLogoin
{
    [Activity(Label = "MvpLogoin")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
           
            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);
            var a = Intent.GetStringExtra("user");
            button.Text = a;
            button.Click += Button_Click;

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(ActivityList));
            StartActivity(intent);
        }
    }
}

