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
using NSACL.PullToRefreshData;

namespace MvpLogoin.Model.Mod
{

    public class PullDownRequest
    {
        public PtrRequest PtrRequest;
    }
    public class PullDownResult
    {
        public ResultType Type;
        public string ErrorMsg;
    }

    public enum ResultType
    {
        /// <summary>
        /// ³É¹¦
        /// </summary>
        Success = 0,
        /// <summary>
        /// Ê§°Ü
        /// </summary>
        Error = 1

    }
}