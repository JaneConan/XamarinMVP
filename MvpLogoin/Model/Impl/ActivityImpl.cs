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
using System.Threading.Tasks;
using MvpLogoin.Model.Net;

using MvpLogoin.Model.Interface;
using MvpLogoin.Model.Listener;

namespace MvpLogoin.Model.Impl
{
    public class ActivityImpl : ActivityNet, IActivity
    {
        Activity activity;
        public ActivityImpl(Activity context) : base(context)
        {
            activity = context;
        }
        public void GetActivitiesData(PullDownRequest postData, OnGetActivityListener activityListener)
        {
            Task.Factory.StartNew(() =>
            {
                try
                {
                    List<string> List = new List<string>();
                    for (int i = 0; i < 10; i++)
                    {
                        List.Add("»î¶¯" + i);
                    }
                    MyAdapter adapter = new MyAdapter(activity, List);
                    activityListener.GetSuccess(adapter);
                }
                catch (Exception e)
                {
                    activityListener.GetFailed();
                }
            });
        }
    }
    public class MyAdapter : BaseAdapter
    {
        List<string> List;
        Activity context;
        public MyAdapter(Activity con, List<string> list)
        {
            context = con;
            List = list;
        }
        public override int Count
        {
            get
            {
                return List.Count;
            }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return List[position];
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            if (convertView == null)
            {
                convertView = context.LayoutInflater.Inflate(Resource.Layout.Item, null);
                ViewData vd = new ViewData();
                vd.AcName = convertView.FindViewById<TextView>(Resource.Id.acname);
                vd.AcName.Text = List[position];
                convertView.Tag = vd;
            }
            else
            {
                ViewData vd = (ViewData)convertView.Tag;
                vd.AcName.Text = List[position];
            }
            return convertView;
        }
        public class ViewData : Java.Lang.Object
        {
            public TextView AcName { get; set; }
        }
    }
}