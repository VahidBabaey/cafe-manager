using Cafe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSecurity
{
    public static class SecurityClass
    {
        public static User UserOnline { get; private set; }

        public static DateTime UserTime { get; private set; }

        public static bool IsAthen { get; private set; }

        public static void GetAthen(string UserName, string Password)
        {
            UserTime = DateTime.Now;
            IsAthen = false;
            UserOnline = DbCommon.Context.Users.SingleOrDefault(p => p.UserName == UserName && p.Password == Password);

            if (UserOnline == null)
                throw new Exception("کلمه کاربری یا رمز عبور اشتباه است");

            IsAthen = true;
        }

    }
}
