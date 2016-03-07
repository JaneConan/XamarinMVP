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
        public RequestType request;
    }
    public class PullDownResult
    {
        public ResultType Type;
        public string ErrorMsg;
    }
    public enum RequestType
    {
        /// <summary>
        /// 我的活动
        /// </summary>
        Mine = 0,
        /// <summary>
        /// 发布的活动
        /// </summary>
        Manager = 1,
        /// <summary>
        /// 已结束的活动
        /// </summary>
        Finish = 2,
        /// <summary>
        /// 缺席的活动
        /// </summary>
        Leave = 3,
        /// <summary>
        /// 招募活动
        /// </summary>
        All = 4
    }
    public enum ResultType
    {
        /// <summary>
        /// 成功
        /// </summary>
        Success = 0,
        /// <summary>
        /// 失败
        /// </summary>
        Error = 1

    }
}