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

namespace MvpLogoin.Model.Net
{
    public class ActivityNet: BaseNet
    {
        public ActivityNet(Context context) : base(context) { }
        public void GetActivitiesData(PullDownRequest postData)
        {

        }
    }
}