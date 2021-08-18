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
    public partial class FormListOrder : Form
    {
        Client SelectedClient = null;
        FormOrder SelectedOrder = null;
        Client _selectedclient = null;
        public FormListOrder()
        {
            InitializeComponent();
        }    
        private void Search_Click(object sender, EventArgs e)
        {
            ShowForm();
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

        private void FormListOrder_Load(object sender, EventArgs e)
        {
            if(SelectedClient != null)
            {
                ShowFoodForClient();
            }
         // ShowOerder();
            ShowForm();
            ShowSum();
        }

        private void ShowSum()
        {
            int jang = 0;
            for (int i = 0; i < GridOrder.Rows.Count; i++)
            {
                jang += Convert.ToInt32(GridOrder.Rows[i].Cells[1].Value);
            }
            this.Text = jang.ToString();
            txtmask.Text = jang.ToString();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            ShowInfo();

        }

        private void ShowInfo()
        {
            var _list = DbCommon.Context.Clients.Select(p => new { p.ID, p.Code, p.LastName });
            GridClient.AutoGenerateColumns = false;
            GridClient.DataSource = _list.ToList();
        }

        private void RegisterClient_Click(object sender, EventArgs e)
        {
            FormListClient a = new FormListClient();
            a.ShowDialog();
        }

        private void GridClient_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            int id = Convert.ToInt32(GridClient[2, e.RowIndex].Value);
            SelectedClient = DbCommon.Context.Clients.SingleOrDefault(p => p.ID == id);
            GridClient.Rows[e.RowIndex].Selected = true;
            if(SelectedClient != null)
            {
                ShowFoodForClient();
            }
            ShowOerder();
            ShowSum();
        }

        private void ShowFoodForClient()
        {
            GridOrder.AutoGenerateColumns = false;
            var _list = SelectedClient.FormOrders.Select(p => new { p.ID, p.FoodName, p.History, p.Price, p.Thakh });
            GridOrder.DataSource = _list.ToList();
            
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if(SelectedClient == null)
            {
                MyMessagebox.ShowMessageValidation("لطفا موردی را از لیست مشتری ها پیدا کنید");
                return;
            }
            if(SelectedClient.Code == 0)
            {
                MyMessagebox.ShowMessageValidation("لطفا مشتری مورد نظر را از لیست مشتری ها انتخاب کنید");
                return;
            }
            FormRegisterOrder b = new FormRegisterOrder(SelectedClient);
            b.ShowDialog();
            if(b.IsChanged)
                ShowFoodForClient();
            ShowSum();
        }

        private void GridOrder_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(GridOrder[2, e.RowIndex].Value);
            SelectedOrder = DbCommon.Context.FormOrders.SingleOrDefault(p => p.ID == id);
            GridOrder.Rows[e.RowIndex].Selected = true;
            Clear2();

          
        }

        private void Clear2()
        {
            txt1s.Text = "";
            txt1s.Focus();
            txt2gh.Text = "";
            txt2gh.Focus();
            txt3ghth.Text = "";
            txt3ghth.Focus();
            txt4h.Text = "";
            txt4h.Focus();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (SelectedOrder == null)
            {
                MyMessagebox.ShowMessageSelection("لطفا موردی را از لیست سوابق انتخاب کنید");
                return;
            }
            DbCommon.Context.FormOrders.Remove(SelectedOrder);
            DbCommon.Context.SaveChanges();
            SelectedOrder = null;
            ShowFoodForClient();
            ShowSum();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if(SelectedOrder == null)
            {
                MyMessagebox.ShowMessageSelection("لطفا موردی را از لیست سوابق انتخاب کنید");
                return;
            }
            FormRegisterOrder g = new FormRegisterOrder(SelectedClient, SelectedOrder);
            g.ShowDialog();
            GridOrder.AutoGenerateColumns = false;
            GridOrder.DataSource = SelectedClient.FormOrders.Select(p => new { p.ID, p.FoodName, p.History, p.Price, p.Thakh }).ToList();
            ShowSum();
        }

        private void Sum_Click(object sender, EventArgs e)
        {
            ShowSum();
        }

        private void SearchOreder_Click(object sender, EventArgs e)
        {
            ShowOerder();
            ShowSum();
        }

        private void ShowOerder()
        {
            string _datetime = txtdate.Text.Trim();
            var _list = DbCommon.Context.FormOrders.Select(p => new { p.ID, p.FoodName, p.History, p.Price, p.Thakh, p.ClientID })
                .Where(p => p.History.Contains(_datetime) && p.ClientID == SelectedClient.ID);
              _list.SingleOrDefault(p => p.ID == SelectedClient.ID);
            GridOrder.AutoGenerateColumns = false;
            GridOrder.DataSource = _list.ToList();
        }

        private void RefreshOrder_Click(object sender, EventArgs e)
        {
            ShowFoodForClient();
            ShowSum();
        }

        private void RegisterNor_Click(object sender, EventArgs e)
        {
            var id = DbCommon.Context.Clients.SingleOrDefault(p => p.Code == 0);
            _selectedclient = id;
            if (SelectedClient != null && SelectedClient.Code != 0)
            {
                MyMessagebox.ShowMessageValidation("جهت ثبت سفارش با کد مشخص بر روی دکمه ' ثبت با کد ' کلیک کنید ");
                return;
            }
            FormRegisterOrder h = new FormRegisterOrder(_selectedclient);
            h.ShowDialog();
            if (h.IsChanged)
                ShowFoodForClient();
            ShowSum();
        }

        private void GridOrder_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt1s.Text = SelectedOrder.FoodName;
            txt2gh.Text = SelectedOrder.Price.ToString();
            txt3ghth.Text = SelectedOrder.Thakh.ToString();
            txt4h.Text = SelectedOrder.History;
           // stiReport6.RegBusinessObject("ListOrder", GridOrder.DataSource);
            stiReport6.Compile();
            stiReport6["Codee"] = SelectedClient.Code.ToString();
            stiReport6["Datetime"] = DateTime.Now.ToShortTimeString();
            stiReport6["Date"] = txtdate.Text;
            stiReport6["Sefaresh"] = txt1s.Text;
            stiReport6["Ghamat"] = txt2gh.Text;
            stiReport6["Ghamatth"] = txt3ghth.Text;
            stiReport6["His"] = txt4h.Text;
            stiReport6.Render(true);
            stiReport6.Show();
        }


    }
}
