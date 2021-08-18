using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System
{
   public static class ErrorHandler
    {
        public static string ErrorMessage { get; private set; }
        public static void GetError(Exception ex)
        {
            ErrorMessage = ex.Message;
            if (ex.GetType() == typeof(FormatException))
            {
                ErrorMessage = " خطای فرمت ";
            }
            if (ex.GetType() == typeof(DivideByZeroException))
            {
                ErrorMessage = " خطای تقسیم بر صفر ";
            }
            if (ex.GetType() == typeof(System.Data.Entity.Infrastructure.DbUpdateException))
            {
                SqlException exSql = ex.InnerException.InnerException as SqlException;
                SqlServerError(exSql);
            }
            if (ex.GetType() == typeof(SqlException))
            {
                SqlException exSql = ex as SqlException;
                SqlServerError(exSql);
            }
            if(ex.GetType() == typeof(ValidationConstraints))
            {
                ErrorMessage = "اطلاعات تکراری است"; 
            }

            MyMessagebox.ShowMessageValidation(ErrorMessage);
        }

        private static void SqlServerError(SqlException exSql)
        {
            ErrorMessage = "خطای پایگاه داده";
            switch (exSql.Number)
            {
                case 2: { ErrorMessage = " به پایگاه داده دسترسی ندارید "; break; }
                case 2627: { ErrorMessage = " اطلاعات تکراری است "; break; }
                case 547: { ErrorMessage = " به دلیل اینکه اطلاعات در قسمت های دیگر استفاده شده است قابل تغییر نیست "; break; }

            }
        }
    }
}
