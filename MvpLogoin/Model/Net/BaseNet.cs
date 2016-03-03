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
using NSACL.Net;

namespace MvpLogoin.Model.Net
{
    public class BaseNet
    {
        protected HttpUtility Http;
        public Context BaseContext;

        public BaseNet(Context context)
        {
            BaseContext = context;
            Http = HttpUtility.Instance;
        }

        public String GetUrl(int resID)
        {
            String baseUrl = BaseContext.GetString(Resource.String.BaseUrl);
            String appendUrl = BaseContext.GetString(resID);
            return String.Format("http://{0}/{1}", baseUrl, appendUrl);
        }
    }
}