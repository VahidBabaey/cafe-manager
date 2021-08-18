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
    public partial class FormListKharid : Form
    {
        Kharid SelectedKharid = null;
        FormOrder SelectedOrder = null;
        int k;
        int s;
        int m;

        public FormListKharid()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            FormKharid a = new FormKharid();
            a.ShowDialog();
            if (a.IsChanged)
                ShowForm();
            ShowSum();
            ClearText();
        }

        private void ShowForm()
        {
            string _kalaname = txtKalaName.Text.Trim();
            string _day = txtDay.Text.Trim();
            string _mounth = txtMounth.Text.Trim();
            string _history = txtHistory.Text.Trim();
            long _price = txtPrice.ConvertInt64();
            var _list = DbCommon.Context.Kharids.Select(p => new { p.Day, p.ID, p.KalaName, p.Mounth, p.Price, p.History })
                .Where(p => p.KalaName.Contains(_kalaname) && p.Day.Contains(_day) && p.Mounth.Contains(_mounth) && p.History.Contains(_history) && (p.Price == _price || _price == 0));
            GridMember.AutoGenerateColumns = false;
            GridMember.DataSource = _list.ToList();
        }

        private void GridMember_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectedKharid = DbCommon.Context.Kharids.Find(GridMember[5, e.RowIndex].Value);
            GridMember.Rows[e.RowIndex].Selected = true;
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (SelectedKharid == null)
            {
                MyMessagebox.ShowMessageSelection();
                return;
            }
            DbCommon.Context.Kharids.Remove(SelectedKharid);
            DbCommon.Context.SaveChanges();
            MyMessagebox.ShowMessageSuccess("اطلاعات با موفقیت حذف شد");
            SelectedKharid = null;
            var _list = DbCommon.Context.Kharids.Select(p => new { p.Day, p.ID, p.KalaName, p.Mounth, p.Price, p.History });
            GridMember.AutoGenerateColumns = false;
            GridMember.DataSource = _list.ToList();
            ShowSum();
            ClearText();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (SelectedKharid == null)
            {
                MyMessagebox.ShowMessageSelection();
                return;
            }
            FormKharid b = new FormKharid(SelectedKharid);
            b.ShowDialog();
            if(b.IsChanged)
                ShowForm();
            var _list = DbCommon.Context.Kharids.Select(p => new { p.Day, p.ID, p.KalaName, p.Mounth, p.Price, p.History });
            GridMember.AutoGenerateColumns = false;
            GridMember.DataSource = _list.ToList();
            ShowSum();
            ClearText();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            var _list = DbCommon.Context.Kharids.Select(p => new { p.Day, p.ID, p.KalaName, p.Mounth, p.Price, p.History });
            GridMember.AutoGenerateColumns = false;
            GridMember.DataSource = _list.ToList();
            ShowSum();
            ClearText();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            ShowForm();
            ShowSum();
            ClearText();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormListKharid_Load(object sender, EventArgs e)
        {
            ShowForm();
            ShowSum();
            ShowFormSell();
            ShowSumSell();
            ClearText();
            
        }

        private void ShowFormSell()
        {
            var _list = DbCommon.Context.FormOrders.Select(p => new { p.ID, p.FoodName, p.History, p.Price });
            GridSell.AutoGenerateColumns = false;
            GridSell.DataSource = _list.ToList();
        }

        private void ShowSumSell()
        {
            int yum = 0;
            for (int j = 0; j < GridSell.Rows.Count; j++)
            {
                yum += Convert.ToInt32(GridSell.Rows[j].Cells[1].Value);
            }
            this.Text = yum.ToString();
            txtSumSell.Text = yum.ToString();
        }

        private void ShowSum()
        {
            int sum = 0;
            for (int i = 0; i < GridMember.Rows.Count; i++)
            {
                sum += Convert.ToInt32(GridMember.Rows[i].Cells[1].Value);
            }
            this.Text = sum.ToString();
            txtSum.Text = sum.ToString();
        }

        private void txtSum_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void GridSell_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectedOrder = DbCommon.Context.FormOrders.Find(GridSell[3, e.RowIndex].Value);
            GridSell.Rows[e.RowIndex].Selected = true;
        }

        private void RemoveSell_Click(object sender, EventArgs e)
        {
            if(SelectedOrder == null)
            {
                MyMessagebox.ShowMessageSelection("لطفا موردی را از لیست فروش انتخاب کنید");
                return;
            }
            DbCommon.Context.FormOrders.Remove(SelectedOrder);
            DbCommon.Context.SaveChanges();
            MyMessagebox.ShowMessageSuccess("اطلاعات با موفقیت حذف شد");
            SelectedOrder = null;
            ShowFormSell();
            ClearText();
            txtMah.Text = "";
            txtMah.Focus();
        }

        private void SearchSell_Click(object sender, EventArgs e)
        {
            ShowSearch();
            ShowSumSell();
            ClearText();
            txtMah.Text = "";
            txtMah.Focus();
        }

        private void ShowSearch()
        {

            string _date;
            if(txtMah.Text != "")
            {
            _date = txtMah.Text;
            string _foodname = txtFoodName.Text;
            var _list = DbCommon.Context.FormOrders.Select(p => new { p.ID, p.FoodName, p.History, p.Price })
                .Where(p => p.FoodName.Contains(_foodname) && p.History.Contains(_date));
            GridSell.AutoGenerateColumns = false;
            GridSell.DataSource = _list.ToList();
            }
            else
            {
                _date = txtdate.Text;
                string _foodname = txtFoodName.Text;
                var _list = DbCommon.Context.FormOrders.Select(p => new { p.ID, p.FoodName, p.History, p.Price })
                    .Where(p => p.FoodName.Contains(_foodname) && p.History.Contains(_date));
                GridSell.AutoGenerateColumns = false;
                GridSell.DataSource = _list.ToList();
            }
            
        }

        private void RefreshSell_Click(object sender, EventArgs e)
        {
            ShowFormSell();
            ShowSumSell();
            ClearText();
            txtMah.Text = "";
            txtMah.Focus();
        }

        private void ClearText()
        {
            txtSood.Text = "";
            txtSood.Focus();
        }

        private void Sood_Click(object sender, EventArgs e)
        {
            k = Convert.ToInt32(txtSum.Text);
            s = Convert.ToInt32(txtSumSell.Text);
            m = s - k;
            txtSood.Text = m.ToString();
        }

        private void RefreshKharid_Click(object sender, EventArgs e)
        {
            var _list = DbCommon.Context.Kharids.Select(p => new { p.ID, p.KalaName, p.Mounth, p.Price, p.Day, p.History });
            GridMember.AutoGenerateColumns = false;
            GridMember.DataSource = _list.ToList();
        }



    }
}
