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
using MvpLogoin.Model.Interface;
using MvpLogoin.Model.Listener;

namespace MvpLogoin.Presenter
{
    public class GetActivityPresenter : OnGetActivityListener
    {
        private IActivity Activity;
        private IActivityView ActivityView;
        private Handler mHandler = new Handler();
        public GetActivityPresenter(IActivityView activityview, Activity context)
        {
            this.ActivityView = activityview;
            this.Activity = new ActivityImpl(context);
        }
        public void GetActivity()
        {
            Activity.GetActivitiesData(null, this);
        }
        public void GetFailed()
        {
            mHandler.Post(() =>
            {
                ActivityView.ShowFailed();
              
            });
        }

        public void GetSuccess(MyAdapter adapter)
        {
            mHandler.Post(() =>
            {
                ActivityView.ShowList(adapter);
                
            });
        }
    }
}