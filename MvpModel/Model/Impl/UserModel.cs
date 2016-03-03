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
using System.Threading.Tasks;

namespace MvpModel.Model.Impl
{
    public class UserModel : IUserModel
    {
        public int GetID()
        {
            return 0;
        }

        public UserBean Load(int id)
        {
            // 查数据库或者联网获取id的userbean
            return new UserBean("11", "22");
        }

        public void SetFirstName(string firstName)
        {

        }

        public void SetID(int id)
        {

        }

        public void SetLastName(string lastName)
        {

        }
    }
}