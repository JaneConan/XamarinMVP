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
using MvpLogoin.Views;
using MvpLogoin.Presenter;
using MvpLogoin.Model.Impl;

namespace MvpLogoin
{
    [Activity(Label = "Activity")]
    public class ActivityList : Activity, IActivityView
    {
        private GetActivityPresenter mGetActivityPresenter;
        private ListView listview;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.List);
            mGetActivityPresenter = new GetActivityPresenter(this, this);
            mGetActivityPresenter.GetActivity();
            listview= FindViewById<ListView>(Resource.Id.listView1);
            // Create your application here
        }

        public void ShowFailed()
        {
            Toast.MakeText(this, "获取信息失败", ToastLength.Short).Show();
        }

        public void ShowList(MyAdapter adapter)
        {
            listview.Adapter = adapter;
            listview.DeferNotifyDataSetChanged();
        }
    }
}