using Cafe.Model;
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
    public partial class FormKharid : Form
    {
        Kharid _kharid = null;

        public bool IsChanged { get; private set; }
        public FormKharid(Kharid pkharid = null)
        {
            InitializeComponent();

            _kharid = pkharid;

            IsChanged = false;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if(txtKalaName.Text.Trim() == "" )
            {
                MyMessagebox.ShowMessageValidation("لطفا نام کالا را وارد کنید");
                return;
            }
            if(txtPrice.Text.Trim() == "")
            {
                MyMessagebox.ShowMessageValidation("لطفا قیمت خرید کالا را وارد کنید");
                return;
            }
            if(ComboDay.Text.Trim() == "")
            {
                MyMessagebox.ShowMessageValidation("لطفا روز خرید کالا را وارد کنید");
                return;
            }
            if(ComboMounth.Text.Trim() == "")
            {
                MyMessagebox.ShowMessageValidation("لطفا ماه خرید کالا را وارد کنید");
                return;
            }
            if(_kharid == null)
            {
                _kharid = new Kharid();
                DbCommon.Context.Kharids.Add(_kharid);
            }
            _kharid.KalaName = txtKalaName.Text.Trim();
            _kharid.Price = txtPrice.ConvertInt64();
            _kharid.Day = ComboDay.Text.Trim();
            _kharid.Mounth = ComboMounth.Text.Trim();
            _kharid.History = txtdate.Text.Trim();
            DbCommon.Save();
            IsChanged = true;
            Close();
        }

        private void FormKharid_Load(object sender, EventArgs e)
        {
            if(_kharid != null)
            {
                ShoworiginalInfo();
            }
        }

        private void ShoworiginalInfo()
        {
            txtKalaName.Text = _kharid.KalaName;
            txtPrice.Text = _kharid.Price.ToString();
            ComboDay.Text = _kharid.Day;
            ComboMounth.Text = _kharid.Mounth;
            txtdate.Text = _kharid.History;

        }

        private void Exit_Clcik(object sender, EventArgs e)
        {
            Close();
        }

    }
}
