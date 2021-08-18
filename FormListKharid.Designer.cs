namespace Cafe
{
    partial class FormListKharid
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListKharid));
            this.GridMember = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHistory = new System.Windows.Forms.TextBox();
            this.txtMounth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKalaName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.MaskedTextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.txtSum = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GridSell = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSumSell = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtdate = new BehComponents.DateTimePickerX();
            this.button10 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMah = new System.Windows.Forms.TextBox();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.txtSood = new System.Windows.Forms.MaskedTextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridMember)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSell)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridMember
            // 
            this.GridMember.AllowUserToAddRows = false;
            this.GridMember.AllowUserToDeleteRows = false;
            this.GridMember.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridMember.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.GridMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.GridMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GridMember.Location = new System.Drawing.Point(118, 110);
            this.GridMember.Margin = new System.Windows.Forms.Padding(2);
            this.GridMember.Name = "GridMember";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridMember.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GridMember.RowTemplate.Height = 24;
            this.GridMember.Size = new System.Drawing.Size(704, 519);
            this.GridMember.TabIndex = 0;
            this.GridMember.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridMember_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "KalaName";
            this.Column1.HeaderText = "نام خرید";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 140;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Price";
            this.Column2.HeaderText = "قیمت خرید";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 130;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Day";
            this.Column3.HeaderText = "روز";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Mounth";
            this.Column4.HeaderText = "ماه";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 130;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "History";
            this.Column5.HeaderText = "تاریخ";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 140;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ID";
            this.Column6.HeaderText = "ID";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.Location = new System.Drawing.Point(493, 634);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 34);
            this.button2.TabIndex = 14;
            this.button2.Text = "ثبت جدید";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Register_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Location = new System.Drawing.Point(397, 634);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "حذف";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Remove_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button4.Location = new System.Drawing.Point(297, 634);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 34);
            this.button4.TabIndex = 17;
            this.button4.Text = "ویرایش";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Edit_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button5.Location = new System.Drawing.Point(684, 634);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 34);
            this.button5.TabIndex = 18;
            this.button5.Text = "بروزرسانی";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button6.Location = new System.Drawing.Point(18, 29);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 34);
            this.button6.TabIndex = 19;
            this.button6.Text = "جستجو";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Search_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.txtHistory);
            this.groupBox1.Controls.Add(this.txtMounth);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.txtSum);
            this.groupBox1.Controls.Add(this.txtDay);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtKalaName);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.GridMember);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(609, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(844, 711);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو کالا";
            // 
            // txtHistory
            // 
            this.txtHistory.Location = new System.Drawing.Point(113, 37);
            this.txtHistory.Margin = new System.Windows.Forms.Padding(2);
            this.txtHistory.Name = "txtHistory";
            this.txtHistory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtHistory.Size = new System.Drawing.Size(76, 23);
            this.txtHistory.TabIndex = 29;
            // 
            // txtMounth
            // 
            this.txtMounth.Location = new System.Drawing.Point(229, 35);
            this.txtMounth.Margin = new System.Windows.Forms.Padding(2);
            this.txtMounth.Name = "txtMounth";
            this.txtMounth.Size = new System.Drawing.Size(76, 23);
            this.txtMounth.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "تاریخ:";
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(338, 35);
            this.txtDay.Margin = new System.Windows.Forms.Padding(2);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(76, 23);
            this.txtDay.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "ماه:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(673, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "نام کالا:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "روز:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(528, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "قیمت خرید:";
            // 
            // txtKalaName
            // 
            this.txtKalaName.Location = new System.Drawing.Point(593, 32);
            this.txtKalaName.Margin = new System.Windows.Forms.Padding(2);
            this.txtKalaName.Name = "txtKalaName";
            this.txtKalaName.Size = new System.Drawing.Size(76, 23);
            this.txtKalaName.TabIndex = 23;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPrice.Location = new System.Drawing.Point(447, 32);
            this.txtPrice.Mask = "00000000000";
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(76, 24);
            this.txtPrice.TabIndex = 24;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(11, 790);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(56, 32);
            this.button8.TabIndex = 32;
            this.button8.Text = "خروج";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Exit_Click);
            // 
            // txtSum
            // 
            this.txtSum.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSum.Location = new System.Drawing.Point(5, 234);
            this.txtSum.Mask = "00000000000000000";
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(100, 24);
            this.txtSum.TabIndex = 32;
            this.txtSum.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtSum_MaskInputRejected);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 218);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "جمع کل:";
            // 
            // GridSell
            // 
            this.GridSell.AllowUserToAddRows = false;
            this.GridSell.AllowUserToDeleteRows = false;
            this.GridSell.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridSell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridSell.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column7,
            this.Column8});
            this.GridSell.Location = new System.Drawing.Point(144, 159);
            this.GridSell.Margin = new System.Windows.Forms.Padding(2);
            this.GridSell.Name = "GridSell";
            this.GridSell.RowTemplate.Height = 24;
            this.GridSell.Size = new System.Drawing.Size(413, 497);
            this.GridSell.TabIndex = 33;
            this.GridSell.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridSell_CellMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FoodName";
            this.dataGridViewTextBoxColumn1.HeaderText = "سفارشات";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 140;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn2.HeaderText = "قیمت کل";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "History";
            this.Column7.HeaderText = "تاریخ";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 170;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "ID";
            this.Column8.HeaderText = "ID";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // txtSumSell
            // 
            this.txtSumSell.Location = new System.Drawing.Point(36, 234);
            this.txtSumSell.Mask = "0000000000000000";
            this.txtSumSell.Name = "txtSumSell";
            this.txtSumSell.Size = new System.Drawing.Size(103, 24);
            this.txtSumSell.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 206);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "جمع کل:";
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button9.Location = new System.Drawing.Point(155, 661);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(90, 34);
            this.button9.TabIndex = 36;
            this.button9.Text = "حذف";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.RemoveSell_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtdate);
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtMah);
            this.groupBox2.Controls.Add(this.txtFoodName);
            this.groupBox2.Controls.Add(this.GridSell);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.txtSumSell);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(33, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(571, 711);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "قسمت فروش";
            // 
            // txtdate
            // 
            this.txtdate.AnchorSize = new System.Drawing.Size(124, 28);
            this.txtdate.BackColor = System.Drawing.Color.White;
            this.txtdate.CalendarBoldedDayForeColor = System.Drawing.Color.Blue;
            this.txtdate.CalendarBorderColor = System.Drawing.Color.CadetBlue;
            this.txtdate.CalendarDayRectTickness = 2F;
            this.txtdate.CalendarDaysBackColor = System.Drawing.Color.LightGray;
            this.txtdate.CalendarDaysFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.CalendarDaysForeColor = System.Drawing.Color.DodgerBlue;
            this.txtdate.CalendarEnglishAnnuallyBoldedDates = new System.DateTime[0];
            this.txtdate.CalendarEnglishBoldedDates = new System.DateTime[0];
            this.txtdate.CalendarEnglishHolidayDates = new System.DateTime[0];
            this.txtdate.CalendarEnglishMonthlyBoldedDates = new System.DateTime[0];
            this.txtdate.CalendarHolidayForeColor = System.Drawing.Color.Red;
            this.txtdate.CalendarHolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday;
            this.txtdate.CalendarLineWeekColor = System.Drawing.Color.Black;
            this.txtdate.CalendarPersianAnnuallyBoldedDates = new BehComponents.PersianDateTime[0];
            this.txtdate.CalendarPersianBoldedDates = new BehComponents.PersianDateTime[0];
            this.txtdate.CalendarPersianHolidayDates = new BehComponents.PersianDateTime[0];
            this.txtdate.CalendarPersianMonthlyBoldedDates = new BehComponents.PersianDateTime[0];
            this.txtdate.CalendarShowToday = true;
            this.txtdate.CalendarShowTodayRect = true;
            this.txtdate.CalendarShowToolTips = false;
            this.txtdate.CalendarShowTrailing = true;
            this.txtdate.CalendarStyle_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.txtdate.CalendarStyle_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.txtdate.CalendarStyle_MonthButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.txtdate.CalendarStyle_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.txtdate.CalendarStyle_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.txtdate.CalendarStyle_YearButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.txtdate.CalendarTitleBackColor = System.Drawing.Color.Wheat;
            this.txtdate.CalendarTitleFont = new System.Drawing.Font("Tahoma", 7.8F);
            this.txtdate.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.txtdate.CalendarTodayBackColor = System.Drawing.Color.Wheat;
            this.txtdate.CalendarTodayFont = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.txtdate.CalendarTodayForeColor = System.Drawing.Color.Black;
            this.txtdate.CalendarTodayRectColor = System.Drawing.Color.Coral;
            this.txtdate.CalendarTodayRectTickness = 2F;
            this.txtdate.CalendarTrailingForeColor = System.Drawing.Color.DarkGray;
            this.txtdate.CalendarType = BehComponents.CalendarTypes.Persian;
            this.txtdate.CalendarWeekDaysBackColor = System.Drawing.Color.Wheat;
            this.txtdate.CalendarWeekDaysFont = new System.Drawing.Font("Tahoma", 7.8F);
            this.txtdate.CalendarWeekDaysForeColor = System.Drawing.Color.OrangeRed;
            this.txtdate.CalendarWeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday;
            this.txtdate.ClearButtonAlignment = BehComponents.DropDownEmpty.Alignments.Left;
            this.txtdate.ClearButtonBackColor = System.Drawing.Color.White;
            this.txtdate.ClearButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.txtdate.ClearButtonImage = ((System.Drawing.Image)(resources.GetObject("txtdate.ClearButtonImage")));
            this.txtdate.ClearButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtdate.ClearButtonImageFixedSize = new System.Drawing.Size(0, 0);
            this.txtdate.ClearButtonImageSizeMode = BehComponents.DropDownEmpty.ImageSizeModes.Zoom;
            this.txtdate.ClearButtonText = "";
            this.txtdate.ClearButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtdate.ClearButtonToolTip = "";
            this.txtdate.ClearButtonWidth = 17;
            this.txtdate.ClearDateTimeWhenDownDeleteKey = true;
            this.txtdate.CustomFormat = "";
            this.txtdate.DockSide = BehComponents.DropDownEmpty.Alignments.Left;
            this.txtdate.DropDownClosedWhenClickOnDays = false;
            this.txtdate.DropDownClosedWhenSelectedDateChanged = false;
            this.txtdate.Format = BehComponents.DateTimePickerX.FormatDate.Long;
            this.txtdate.Format4Binding = "yyyy/MM/dd";
            this.txtdate.Location = new System.Drawing.Point(134, 53);
            this.txtdate.Margin = new System.Windows.Forms.Padding(4);
            this.txtdate.Name = "txtdate";
            this.txtdate.RightToLeftLayout = true;
            this.txtdate.ShowClearButton = false;
            this.txtdate.Size = new System.Drawing.Size(124, 28);
            this.txtdate.TabIndex = 252;
            this.txtdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtdate.TextWhenClearButtonClicked = "";
            // 
            // button10
            // 
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button10.Location = new System.Drawing.Point(467, 671);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(90, 34);
            this.button10.TabIndex = 39;
            this.button10.Text = "بروزرسانی";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.RefreshSell_Click);
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button7.Location = new System.Drawing.Point(11, 44);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(90, 34);
            this.button7.TabIndex = 32;
            this.button7.Text = "جستجو";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.SearchSell_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(352, 63);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 17);
            this.label9.TabIndex = 38;
            this.label9.Text = "ماه:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(467, 60);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "نام غذا:";
            // 
            // txtMah
            // 
            this.txtMah.Location = new System.Drawing.Point(279, 60);
            this.txtMah.Name = "txtMah";
            this.txtMah.Size = new System.Drawing.Size(68, 24);
            this.txtMah.TabIndex = 37;
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(392, 57);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(70, 24);
            this.txtFoodName.TabIndex = 32;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Red;
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button11.Location = new System.Drawing.Point(766, 772);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(143, 34);
            this.button11.TabIndex = 40;
            this.button11.Text = "محاسبه سود ماهیانه";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.Sood_Click);
            // 
            // txtSood
            // 
            this.txtSood.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSood.Location = new System.Drawing.Point(558, 779);
            this.txtSood.Mask = "00000000000000000000000000000000";
            this.txtSood.Name = "txtSood";
            this.txtSood.Size = new System.Drawing.Size(202, 24);
            this.txtSood.TabIndex = 41;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button3.Location = new System.Drawing.Point(780, 634);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 34);
            this.button3.TabIndex = 40;
            this.button3.Text = "بروزرسانی";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.RefreshKharid_Click);
            // 
            // FormListKharid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1863, 833);
            this.Controls.Add(this.txtSood);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormListKharid";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "لیست خرید";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormListKharid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridMember)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSell)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridMember;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKalaName;
        private System.Windows.Forms.MaskedTextBox txtPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHistory;
        private System.Windows.Forms.TextBox txtMounth;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.MaskedTextBox txtSum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView GridSell;
        private System.Windows.Forms.MaskedTextBox txtSumSell;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMah;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.MaskedTextBox txtSood;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button button3;
        private BehComponents.DateTimePickerX txtdate;
    }
}