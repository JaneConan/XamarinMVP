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
using MvpLogoin.Model.Mod;
using MvpLogoin.Model.Listener;

namespace MvpLogoin.Model.Interface
{
    public interface IActivity
    {
        void GetActivitiesData(PullDownRequest postData, OnGetActivityListener activityListener);
    }
}