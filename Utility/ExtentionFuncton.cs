using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace System
{
   public static class ExtentionFuncton
    {

        public static Int16 Convertint16(this TextBoxBase txt)
       {
           return txt.Text.Trim() == "" ? (Int16)0 : Convert.ToInt16(txt.Text.Trim());
       }
        public static Int32 ConvertInt32(this TextBoxBase txt)
        {
            return txt.Text.Trim() == "" ? 0 : Convert.ToInt32(txt.Text.Trim());
        }
        public static Int64 ConvertInt64(this TextBoxBase txt)
        {
            return txt.Text.Trim() == "" ? 0 : Convert.ToInt64(txt.Text.Trim());
        }
        public static int GetValue(this ComboBox Combo)
        {
            return Convert.ToInt32(Combo.SelectedValue);
        }
        public static bool IsValidateEmail(this string strEmail)
        {
            return Regex.IsMatch(strEmail, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
        }

        public static string GetPersian(this DateTime datetime)
        {
            PersianCalendar _persian = new PersianCalendar();
            int _year = _persian.GetYear(datetime);
            int _month = _persian.GetMonth(datetime);
            int _day = _persian.GetDayOfMonth(datetime);
            return _year + "/" + _month + "/" + _day;
        }
        public static string GetPersianDetials(this DateTime datetime)
        {
            PersianCalendar _persian = new PersianCalendar();
            int _year = _persian.GetYear(datetime);
            int _month = _persian.GetMonth(datetime);
            int _day = _persian.GetDayOfMonth(datetime);

            DayOfWeek d = _persian.GetDayOfWeek(datetime);

            string str = " امروز ";
            switch (d)
            {
                case DayOfWeek.Friday: { str += " جمعه "; break; };
                case DayOfWeek.Monday:
                    { str += " جمعه "; break; };
                case DayOfWeek.Saturday:
                    { str += " شنبه "; break; };
                case DayOfWeek.Sunday:
                    { str += " یکشنبه "; break; };
                case DayOfWeek.Thursday:
                    { str += " پنج شنبه "; break; };
                case DayOfWeek.Tuesday:
                    { str += " سه شنبه "; break; };
                case DayOfWeek.Wednesday:
                    { str += " چهارشنبه "; break; };
            }
            str += _day + " ";
            switch (_month)
            {
                case 1: { str += " فروردین ماه "; break; };
                case 2: { str += " اردیبهشت ماه "; break; };
                case 3: { str += " خرداد ماه "; break; };
                case 4: { str += " تیر ماه "; break; };
                case 5: { str += " مرداد ماه "; break; };
                case 6: { str += " شهریور ماه "; break; };
                case 7: { str += " مهر ماه "; break; };
                case 8: { str += " آبان ماه "; break; };
                case 9: { str += " آذر ماه "; break; };
                case 10: { str += " دی ماه "; break; };
                case 11: { str += " بهمن ماه "; break; };
                case 12: { str += " اسفند ماه "; break; };
            }
            str += " سال " + _year;
            return str;
        }
    }
}
