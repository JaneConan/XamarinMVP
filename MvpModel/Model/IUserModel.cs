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
using MvpModel.Bean;

namespace MvpModel.Model
{
    public interface IUserModel
    {
        void SetID(int id);

        void SetFirstName(String firstName);

        void SetLastName(String lastName);

        int GetID();

        UserBean Load(int id);// 通过id读取user信息,返回一个UserBean
    }

}