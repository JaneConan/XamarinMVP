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
        /// �ҵĻ
        /// </summary>
        Mine = 0,
        /// <summary>
        /// �����Ļ
        /// </summary>
        Manager = 1,
        /// <summary>
        /// �ѽ����Ļ
        /// </summary>
        Finish = 2,
        /// <summary>
        /// ȱϯ�Ļ
        /// </summary>
        Leave = 3,
        /// <summary>
        /// ��ļ�
        /// </summary>
        All = 4
    }
    public enum ResultType
    {
        /// <summary>
        /// �ɹ�
        /// </summary>
        Success = 0,
        /// <summary>
        /// ʧ��
        /// </summary>
        Error = 1

    }
}