using AppSecurity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe.AppSecurity
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MyMessagebox.ShowMessageValidation("لطفا کلمه کاربری و رمز عبور را وارد کنید");
                return;
            }
            SecurityClass.GetAthen(txtUserName.Text, txtPassword.Text);
            Close();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !SecurityClass.IsAthen;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
