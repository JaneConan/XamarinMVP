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

namespace MvpLogoin.Model.Mod
{
    public class LoginIn
    {
        public string UserName { get; set; }//用户名
        public string PassWord { get; set; }//密码
    }

    public class LoginOut
    {
        public string UserID { get; set; }//用户名
        public int Code { get; set; }//登陆码
        public string Role { get; set; }//角色
    }
}