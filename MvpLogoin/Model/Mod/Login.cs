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
        public string UserName { get; set; }//�û���
        public string PassWord { get; set; }//����
    }

    public class LoginOut
    {
        public string UserID { get; set; }//�û���
        public int Code { get; set; }//��½��
        public string Role { get; set; }//��ɫ
    }
}