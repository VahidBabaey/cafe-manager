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
    public partial class FormListFood : Form
    {
        Food SelectedFood = null;
        public FormListFood()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if(txtFood.Text.Trim() == "")
            {
                MyMessagebox.ShowMessageValidation("لطفا نام غذا را وارد کنید");
                return;
            }
            if(txWorth.Text.Trim() == "")
            {
                MyMessagebox.ShowMessageValidation("لطفا قیمت غذا را وارد کنید");
                return;
            }
            Food _food = new Food();
         //   _food.FoodName = txtFood.Text.Trim();
            _food.Worth = txWorth.ConvertInt64();
            DbCommon.Context.Foods.Add(_food);
            DbCommon.Context.SaveChanges();
           // DbCommon.Save();
            ClearText();
            var _list = DbCommon.Context.Foods.Select(p => new { p.ID, p.FoodName, p.Worth });
            GridFood.AutoGenerateColumns = false;
            GridFood.DataSource = _list.ToList();

        }

        private void ClearText()
        {
            txtFood.Text = "";
            txWorth.Text = "";
            txtFood.Focus();
            txWorth.Focus();
        }

        private void GridFood_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectedFood = DbCommon.Context.Foods.Find(GridFood[2, e.RowIndex].Value);
          //  txtFood.Text = SelectedFood.FoodName;
            txWorth.Text = SelectedFood.Worth.ToString();
            GridFood.Rows[e.RowIndex].Selected = true;
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if(SelectedFood == null)
            {
                MyMessagebox.ShowMessageSelection();
                return;
            }
            DbCommon.Context.Foods.Remove(SelectedFood);
            DbCommon.Context.SaveChanges();
            MyMessagebox.ShowMessageSuccess("اطلاعات با موفقیت حذف شد");
            SelectedFood = null;
            ClearText();
            var _list = DbCommon.Context.Foods.Select(p => new { p.ID, p.FoodName, p.Worth });
            GridFood.AutoGenerateColumns = false;
            GridFood.DataSource = _list.ToList();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (SelectedFood == null)
            {
                MyMessagebox.ShowMessageSelection();
                return;
            }
      //      SelectedFood.FoodName = txtFood.Text.Trim();
            SelectedFood.Worth = txWorth.ConvertInt64();
            DbCommon.Context.SaveChanges();
            MyMessagebox.ShowMessageSuccess("اطلاعات با موفقیت حذف شد");
            SelectedFood = null;
            ClearText();
            var _list = DbCommon.Context.Foods.Select(p => new { p.ID, p.FoodName, p.Worth });
            GridFood.AutoGenerateColumns = false;
            GridFood.DataSource = _list.ToList();
        }

        private void FormListFood_Load(object sender, EventArgs e)
        {
            GridFood.AutoGenerateColumns = false;
            GridFood.DataSource = DbCommon.Context.Foods.ToList();
            ShowForm();
            //int Sum = new int();
            //foreach (DataGridView row in GridFood.Rows)
            //{
            //    Sum += (int)row.Cells[1].Value;
            //}
        }

        private void ShowForm()
        {
            string _foodname = Foodtxt.Text.Trim();
            long _worth = Worthtxt.ConvertInt64();
            var _list = DbCommon.Context.Foods.Select(p => new { p.ID, p.FoodName, p.Worth }).Where(p => p.FoodName.Contains(_foodname) && (p.Worth == _worth || _worth == 0));
            GridFood.AutoGenerateColumns = false;
            GridFood.DataSource = _list.ToList();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            var _list = DbCommon.Context.Foods.Select(p => new { p.ID, p.FoodName, p.Worth });
            GridFood.AutoGenerateColumns = false;
            GridFood.DataSource = _list.ToList();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            ShowForm();
        }
    }
}
