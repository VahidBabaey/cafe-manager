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
    public partial class FormRegisterOrder : Form
    {
        DataTable dt = null;
        string name;
        long price;
        int m;
        int Row = -1;
        Client _client = null;
        FormOrder _formorder = null;
        FormOrder _form = null;
        long sprice;
        int r;
        long f;
        public bool IsChanged { get; private set; }
        DataSet1 db = new DataSet1();


        public FormRegisterOrder(Client pclient, FormOrder pformorder = null)
        {
            InitializeComponent();
            Conf();
            _client = pclient;
            _formorder = pformorder;
            IsChanged = false;
        }

        private void Conf()
        {
            dt = new DataTable("List");
            dt.Columns.Add("FoodName"); dt.Columns.Add("Worth"); dt.Columns.Add("Number");
            GridOrder.DataSource = dt;
        }

        private void buttonShakechoc_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "شیک شکلات");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
    
        }

        private void Tum(string name, int f, long s)
        {
            txtr.Text += name + " " + f + " عدد - " + " قیمت : " + s + "\n";
        }
        private void Load_Click(object sender, EventArgs e)
        {
            // Tum(name, m, price);
            txtr.Text = GridOrder[0, Row].Value.ToString();
        }

        private void ClearText()
        {
            txtm.Text = "";
            txtm.Focus();
            txtWorth.Text = "";
            txtWorth.Focus();
            Thakh.Text = "";
            Thakh.Focus();
            txtThakh.Text = "";
            txtThakh.Focus();

        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            if (_client != null)
            {

                this.Text += " برای مشتری با کد  " + _client.Code;

                if (_formorder != null)
                {
                    ShowOriginalInfo();
                }
                txtID.Text = _client.Code.ToString();
            }
            GridOrder.DataSource = db.DataTable1;


        }

        private void ShowOriginalInfo()
        {
            txtr.Text = _formorder.FoodName;
            txtdate.Text = _formorder.History;
            txtThakh.Text = _formorder.Thakh.ToString();
            txtWorth.Text = _formorder.Price.ToString();

        }

        private void ShowSum()
        {
            int yum = 0;
            for (int i = 0; i < GridOrder.Rows.Count; i++)
            {
                yum += Convert.ToInt32(GridOrder.Rows[i].Cells[1].Value);
            }
            this.Text = yum.ToString();
            txtWorth.Text = yum.ToString();
        }

        private void ButoonShakM_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "شیک شکلات مخصوص");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            // dt.Rows.Add(name, price, m);
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void ButtonShakCa_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "شیک کارامل");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + "\n" + "\n";


        }

        private void ButtonShakP_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "شیک پرتقال");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void ButtonShakV_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "شیک وانیل");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void ButtonShakD_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "شیک دارک");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            // dt.Rows.Add(name, price, m);
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";

        }

        private void ButtonShakN_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "شیک نوتلا");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";

        }

        private void ButtonShakMo_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "شیک موز");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";

        }

        private void ButtonShakT_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "شیک توت فرنگی");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void ButtonShakAn_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "شیک آناناس");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void ButtonShakAl_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "شیک آلبالو");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void ButtonShakTa_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "شیک طالبی");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void ButtonShakBl_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "شیک بلوبری");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void ButtonShakAna_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "شیک انار");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void ButtonShakKa_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "شیک کره گردویی");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void ButtonShakZo_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "شیک زغالی");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void ButtonShakMi_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "شیک میکس");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void ButtonCakeCakeR_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "کیک روز");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void ButtonCakecakeSh_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "کیک شکلاتی");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "کیک بستنی");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "دسر(کیک,میوه,ژله,بستنی)");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "ژله بستنی");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "بشقاب میوه");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "پلمپیر");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "گلاسه پرتقال");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "گلاسه وانیل");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "گلاسه شکلات");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "گلاسه دارک");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "گلاسه شکلات مخصوص");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "گلاسه نوتلا");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "گلاسه موز");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "گلاسه توت فرنگی");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "گلاسه آناناس");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "گلاسه آلبالو");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "گلاسه طالبی");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "گلاسه بلوبری");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "گلاسه انار");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "گلاسه کره گردویی");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "گلاسه زغالی");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "گلاسه کارامل");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "گلاسه میکس");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "مینی پیتزا گوشت");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "مینی پیتزا گوشت و قارچ");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button52_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "مینی پیتزا چیکن");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button53_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "مینی پیتزا مخصوص");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button51_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "خوراک دیپون");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button50_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "اسنک گوشت");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button49_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "اسنک مرغ");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "اسنک مخصوص");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "اسنک تنوری گوشت");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "اسنک تنوری مرغ");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "اسنک تنوری مخصوص");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button59_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "سیب و پنیر یک نفره");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button58_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "سیب و پنیر دو نفره");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button57_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "هات چیپس تک نفره");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button56_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "هات چیپس دو نفره");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button55_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "سیب سخاری");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button54_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "پاستا");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "سیب و پنیر پیتزایی");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button66_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "آیس کافی");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button67_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "آیس چاکلت");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button63_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "فراپاچینو کلاسیک");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button64_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "فراپاچینو شکلات");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button65_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "فراپاچینو کارامل");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button62_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "لیموناد");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button61_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "لیموناد زنجبیل");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }
        private void button71_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "موهیتو");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button70_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "کایپرینا");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button69_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "آب انار");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button68_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "آب پرتقال");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button76_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "آب آناناس");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button75_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "آب سیب");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button74_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "آب هویج");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button73_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "آب میوه های فصلی");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button72_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "میکس دلخواه");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button60_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "اسموتی ویولت");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button79_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "اسموتی اپل استرابری");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button78_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "اسموتی لمون اپل");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button77_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "اسموتی انبه کیوی");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button84_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "اسموتی تصفیه خون");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button83_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "اسموتی انبه کلمبیایی");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";

        }

        private void button82_Click(object sender, EventArgs e)
        {

            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "اسموتی انرژی");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button81_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "اسموتی لمون آلوئه ورا");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button80_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "اسموتی گریپ فروت");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button91_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "اسموتی فصل");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button92_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "اسموتی ویتامین");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button93_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "اسموتی میکس");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button88_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "بستنی پرتقال");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button89_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "بستنی آناناس");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button90_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "بستنی توت فرنگی");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button98_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "بستنی بلوبری");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button87_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "بستنی وانیل");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button99_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "بستنی تیرامیسور");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button100_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "بستنی شکلات تکه ای");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button101_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "بستنی موز کاکائو");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button102_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "بستنی زغالی");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button97_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "بستنی وانیل توت فرنگی");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button96_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "بستنی میکس");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button113_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "قهوه ریسترتو");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button114_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "قهوه اسپرسو");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button115_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "قهوه دوپیو");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button116_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "قهوه فرنچ پرس");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button117_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "قهوه ترک");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button95_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "قهوه لاته");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button94_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "قهوه موکا");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button86_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "قهوه رمانو");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button85_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "قهوه یونانی");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button108_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "قهوه کنپانا");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button109_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "قهوه نیکرم");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button110_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "قهوه آمریکانو");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button111_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "قهوه کن هیلو");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button112_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "هات چاکلت");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button107_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "دارک چاکلت");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button106_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "وایت چاکلت");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button105_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "چاکلت طعم دار");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button104_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "شیر عسل");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button103_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "شیر عسل دارچین");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button122_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "شیر شکلات");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button121_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "شیر کارامل");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button120_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "شیر کاکائو");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button119_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "شیر پسته");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button118_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "کاپوچینو");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button124_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "شیر نسکافه");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }
        private void button123_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "انرزی درینک");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button130_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "چای ساده");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button131_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "چای زعفرانی");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button132_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "چای ترش");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button133_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "هلاماسلا");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button129_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "چای میوه ای");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button134_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "چای زنجبیل");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button135_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "چای دارچین");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button136_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "چای سبز");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button137_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "چای هل");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button138_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "چای نعنا");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button139_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "آویشن");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button140_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "به لیمو");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button141_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "سرماخوردگی");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button128_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "هفت گیاه");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button127_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "دمنوش میکس دلخواه");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button126_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "دمنوش 2 نفره");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void button125_Click(object sender, EventArgs e)
        {
            if (txtm.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تعداد محصول را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var _list = DbCommon.Context.Foods.SingleOrDefault(p => p.FoodName == "دمنوش 4 نفره");
            name = _list.FoodName;
            price = _list.Worth;
            m = Convert.ToInt16(txtm.Text.Trim());
            price *= m;
            db.DataTable1.AddDataTable1Row(name, price, m);
            ClearText();
            txtr.Text += name + " " + m + " - " + "\n" + "\n";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            if (Row == -1)
            {
                MessageBox.Show("لطفا مورد را انتخاب کنید", "خطا", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }
            GridOrder.Rows.RemoveAt(Row);
            Row = -1;
            ClearText();
            MessageBox.Show("متناسب با حذف جدول سوابق را هم ویرایش کنید", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GridOrder_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            Row = e.RowIndex;
            GridOrder.Rows[e.RowIndex].Selected = true;
            r = Convert.ToInt32(GridOrder[2, Row].Value);
            f = Convert.ToInt64(GridOrder[1, Row].Value);
        }

        private void Showsum_Click(object sender, EventArgs e)
        {
            ShowSum();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (Row == -1)
            {
                MessageBox.Show("لطفا مورد را انتخاب کنید", "خطا", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }
            if (txtm.Text == "")
            {
                MyMessagebox.ShowMessageValidation("لطفا تعداد سفارش مورد نظر را وارد کنید");
                return;
            }
            long h = f / r;
            int y = Convert.ToInt32(txtm.Text);
            long q = h * y;
            txtWorth.Text = "";
            txtWorth.Focus();
            GridOrder[1, Row].Value = q;
            GridOrder[2, Row].Value = txtm.Text.Trim();
            ClearText();
            MessageBox.Show("متناسب با ویرایش جدول سوابق را هم ویرایش کنید", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void Register_Click(object sender, EventArgs e)
        {

                if (txtThakh.Text == "")
                {
                    txtThakh.Text = Convert.ToInt32(0).ToString();
                }
                if (txtdate.Text == "")
                {
                    MyMessagebox.ShowMessageValidation("لطفا تاریخ را وارد کنید");
                    return;
                }
                if (txtWorth.Text == "")
                {
                    MyMessagebox.ShowMessageValidation("قیمت کل ثبت نشده است");
                    return;
                }
                if (_formorder == null)
                {
                    _formorder = new FormOrder();
                    _client.FormOrders.Add(_formorder);
                }

                _formorder.Thakh = Convert.ToInt64(txtThakh.Text);
                _formorder.FoodName = txtr.Text;
                _formorder.Price = Convert.ToInt64(txtWorth.Text);
                _formorder.History = txtdate.Text;
                _formorder.codee = Convert.ToInt32(txtID.Text);
                if (MyMessagebox.showMessageconfirm("آیا لیست سوابق صحیح میباشد؟"))
                {
                    DbCommon.Context.SaveChanges();
                    IsChanged = true;
                }
                MyMessagebox.ShowMessageSuccess("اگر مایل به چاپ فیش هستید بر روی دکمه چاپ بزنید");
            }

        private void Print_Click(object sender, EventArgs e)
        {
            if (GridOrder.RowCount == 0)
            {
                MyMessagebox.ShowMessageValidation("سفارشی در جدول ثبت نشده");
                return;
            }
            if (txtWorth.Text == "")
            {
                MyMessagebox.ShowMessageValidation("لطفا قیمت کل را هم ثبت کنید");
                return;
            }
            if (Thakh.Text != "" && txtThakh.Text == "")
            {
                MyMessagebox.ShowMessageValidation("لطفا قیمت کل با تخفیف را هم ثبت کنید");
                return;
            }

            stiReport3.Dictionary.Variables["DateTime"].Value = DateTime.Now.ToShortTimeString();
            stiReport3.RegBusinessObject("ListOrders", GridOrder.DataSource);
            stiReport3.Compile();
            stiReport3["DarThakh"] = Thakh.Text;
            stiReport3["Thakh"] = txtThakh.Text;
            stiReport3["DateHis"] = txtdate.Text;
            stiReport3["Worthe"] = txtWorth.Text;
            stiReport3["Codee"] = txtID.Text;
            stiReport3.Render(true);
            if (MyMessagebox.showMessageconfirm("آیا تاریخ به درستی ثبت شده است؟"))
            {
                stiReport3.Show();
            }
        }

        private void Takh_Click(object sender, EventArgs e)
        {

            if (Thakh.Text == "")
            {
                MyMessagebox.ShowMessageValidation("لطفا درصد تخفیف را وارد کنید");
                return;
            }
            if (txtWorth.Text == "")
            {
                MyMessagebox.ShowMessageValidation("لطفا ابتدا قیمت کل را ثبت کنید");
                return;
            }
            int all = Convert.ToInt32(txtWorth.Text);
            int takh = Convert.ToInt32(Thakh.Text);
            int w = 100 - takh;
            int th = (all * w) / 100;
            txtThakh.Text = th.ToString();
        }




    }
}
