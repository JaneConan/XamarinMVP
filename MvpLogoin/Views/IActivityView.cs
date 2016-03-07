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
using MvpLogoin.Model.Impl;

namespace MvpLogoin.Views
{
    public interface IActivityView
    {
        void ShowFailed();
        void ShowList(MyAdapter adapter); 
    }
}