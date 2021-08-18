using Cafe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class DbCommon
    {
        public static cafeEntities _Context = new cafeEntities();
        public static cafeEntities Context
        {
            get { return DbCommon._Context; }

        }

        public static void Save()
        {
            _Context.SaveChanges();
            MyMessagebox.ShowMessageSuccess();
        }

    }
}
