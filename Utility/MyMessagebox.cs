using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System
{
   public static class MyMessagebox
    {
       public static void ShowMessageValidation(string Message = "لطفا اطلاعات را وارد کنید")
       {
          MessageBox.Show(Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
       }
       public static void ShowMessageSuccess(string Message = "اطلاعات با موفقیت ثبت شد")
       {
           MessageBox.Show(Message, "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
       }

       public static void ShowMessageSelection(string Message = "لطفا موردی را از لیست انتخاب کنید")
       {
           MessageBox.Show(Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
       }

       public static bool showMessageconfirm(string Message = "آیا عملیات انجام شود؟")
       {
           return MessageBox.Show(Message, "سوال", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
       }
    }
}
