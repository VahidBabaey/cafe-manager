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

namespace Cafe
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            InitioalTime();
        }
        private void InitioalTime()
        {
            Timer t = new Timer();
            t.Interval = 1000;
            t.Tick += t_Tick;
            t.Start();
        }
        void t_Tick(object sender, EventArgs e)
        {
            ShowTime();
        }

        private void FormListKharid_Click(object sender, EventArgs e)
        {
            FormListKharid a = new FormListKharid();
            a.ShowDialog();
        }

        private void FormListFood_Click(object sender, EventArgs e)
        {
            FormListFood b = new FormListFood();
            b.ShowDialog();
        }

        private void FormListClient_Click(object sender, EventArgs e)
        {
            FormListClient c = new FormListClient();
            c.ShowDialog();
        }

        private void FormListOrder_Click(object sender, EventArgs e)
        {
            FormListOrder d = new FormListOrder();
            d.ShowDialog();
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            AppSecurity.FormLogin f = new AppSecurity.FormLogin();
            f.ShowDialog();
            ShowUserInfo();
        }

        private void ShowUserInfo()
        {
            LplUser.Text = SecurityClass.UserOnline.FullName + "\n زمان ورود:  " + SecurityClass.UserTime.ToShortTimeString();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ShowTime();
            ShowDate();
        }

        private void ShowDate()
        {
            label3.Text = DateTime.Now.GetPersianDetials();
        }

        private void ShowTime()
        {
            analogClock1.Time = DateTime.Now;
        }

    }
}
