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
    public partial class FormListClient : Form
    {
        Client SelectedClient = null;
        public FormListClient()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if(txtClientCode.Text.Trim() == "")
            {
                MyMessagebox.ShowMessageValidation("لطفا شماره مشتری را وارد کنید");
                    return;
            }
            if(txtClientLastName.Text.Trim() == "")
            {
                MyMessagebox.ShowMessageValidation("لطفا نام مشتری را وارد کنید");
                return;
            }
            Client _client = new Client();
            _client.Code = txtClientCode.ConvertInt64();
            _client.LastName = txtClientLastName.Text.Trim();
            DbCommon.Context.Clients.Add(_client);
            DbCommon.Save();
            ClearText();
            ShowInfo();
        }

        private void ClearText()
        {
            txtClientCode.Text = "";
            txtClientCode.Focus();
            txtClientLastName.Text = "";
            txtClientLastName.Focus();
        }

        private void GridClient_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectedClient = DbCommon.Context.Clients.Find(GridClient[2, e.RowIndex].Value);
            txtClientLastName.Text = SelectedClient.LastName;
            txtClientCode.Text = SelectedClient.Code.ToString();
            GridClient.Rows[e.RowIndex].Selected = true;
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if(SelectedClient == null)
            {
                MyMessagebox.ShowMessageSelection();
                return;
            }
            DbCommon.Context.Clients.Remove(SelectedClient);
            DbCommon.Context.SaveChanges();
            MyMessagebox.ShowMessageSuccess("اطلاعات با موفقیت حذف شد");
            SelectedClient = null;
            ClearText();
            ShowInfo();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (SelectedClient == null)
            {
                MyMessagebox.ShowMessageSelection();
                return;
            }
            SelectedClient.Code = txtClientCode.ConvertInt64();
            SelectedClient.LastName = txtClientLastName.Text.Trim();
            DbCommon.Context.SaveChanges();
            MyMessagebox.ShowMessageSuccess("اطلاعات با موفقیت ویرایش شد");
            SelectedClient = null;
            ClearText();
            ShowInfo();
        }

        private void ShowInfo()
        {
            var _list = DbCommon.Context.Clients.Select(p => new { p.ID, p.Code, p.LastName });
            GridClient.AutoGenerateColumns = false;
            GridClient.DataSource = _list.ToList();
        }

        private void FormListClient_Load(object sender, EventArgs e)
        {
            ShowForm();
            ShowInfo();
        }

        private void ShowForm()
        {
            string _lastname = txtLastName.Text.Trim();
            long _code = txtCode.ConvertInt64();
            var _list = DbCommon.Context.Clients.Select(p => new { p.ID, p.Code, p.LastName })
                .Where(p => p.LastName.Contains(_lastname) && (p.Code == _code || _code == 0));
            GridClient.AutoGenerateColumns = false;
            GridClient.DataSource = _list.ToList();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            ShowForm();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            ShowInfo();
        }

        private void Clean_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
