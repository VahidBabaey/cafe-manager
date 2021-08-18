namespace Cafe
{
    partial class FormListOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListOrder));
            this.GridClient = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridOrder = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txtmask = new System.Windows.Forms.MaskedTextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.txtdate = new BehComponents.DateTimePickerX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.stiReport6 = new Stimulsoft.Report.StiReport();
            this.txt1s = new System.Windows.Forms.TextBox();
            this.txt2gh = new System.Windows.Forms.MaskedTextBox();
            this.txt3ghth = new System.Windows.Forms.MaskedTextBox();
            this.txt4h = new System.Windows.Forms.TextBox();
            this.group = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridOrder)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.group.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridClient
            // 
            this.GridClient.AllowUserToAddRows = false;
            this.GridClient.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.GridClient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GridClient.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.GridClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.GridClient.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridClient.DefaultCellStyle = dataGridViewCellStyle6;
            this.GridClient.Location = new System.Drawing.Point(5, 161);
            this.GridClient.Margin = new System.Windows.Forms.Padding(2);
            this.GridClient.Name = "GridClient";
            this.GridClient.RowTemplate.Height = 24;
            this.GridClient.Size = new System.Drawing.Size(303, 436);
            this.GridClient.TabIndex = 1;
            this.GridClient.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridClient_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Code";
            this.Column1.HeaderText = "شماری مشتری";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "LastName";
            this.Column2.HeaderText = "نام";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ID";
            this.Column3.HeaderText = "ID";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // GridOrder
            // 
            this.GridOrder.AllowUserToAddRows = false;
            this.GridOrder.AllowUserToDeleteRows = false;
            this.GridOrder.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column8,
            this.Column4,
            this.Column7});
            this.GridOrder.Location = new System.Drawing.Point(210, 146);
            this.GridOrder.Margin = new System.Windows.Forms.Padding(2);
            this.GridOrder.Name = "GridOrder";
            this.GridOrder.RowTemplate.Height = 24;
            this.GridOrder.Size = new System.Drawing.Size(523, 521);
            this.GridOrder.TabIndex = 2;
            this.GridOrder.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridOrder_CellMouseClick);
            this.GridOrder.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridOrder_CellMouseDoubleClick);
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "FoodName";
            this.Column5.HeaderText = "سفارشات";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 170;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Price";
            this.Column6.HeaderText = "قیمت ";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 80;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "ID";
            this.Column8.HeaderText = "ID";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Thakh";
            this.Column4.HeaderText = "قیمت تخفیف خورده";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "History";
            this.Column7.HeaderText = "تاریخ";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 130;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.GridClient);
            this.groupBox1.Location = new System.Drawing.Point(850, 70);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(323, 665);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجوی مشتری";
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button5.Location = new System.Drawing.Point(5, 68);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(68, 34);
            this.button5.TabIndex = 24;
            this.button5.Text = "جستجو";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "نام مشتری:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(110, 76);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(91, 24);
            this.txtLastName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "شماره مشتری:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(110, 26);
            this.txtCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtCode.Mask = "0000000000000000";
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(91, 24);
            this.txtCode.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(335, 701);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 34);
            this.button1.TabIndex = 26;
            this.button1.Text = "ثبت با کد";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Register_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.Location = new System.Drawing.Point(261, 701);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 34);
            this.button2.TabIndex = 27;
            this.button2.Text = "حذف";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Remove_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button3.Location = new System.Drawing.Point(187, 700);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 34);
            this.button3.TabIndex = 28;
            this.button3.Text = "ویرایش";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Edit_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button4.Location = new System.Drawing.Point(777, 594);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 67);
            this.button4.TabIndex = 29;
            this.button4.Text = "ثبت مشتری جدید";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.RegisterClient_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button6.Location = new System.Drawing.Point(766, 178);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 41);
            this.button6.TabIndex = 25;
            this.button6.Text = "بروزرسانی";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // txtmask
            // 
            this.txtmask.Location = new System.Drawing.Point(442, 120);
            this.txtmask.Mask = "0000000000000000";
            this.txtmask.Name = "txtmask";
            this.txtmask.Size = new System.Drawing.Size(97, 24);
            this.txtmask.TabIndex = 30;
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button7.Location = new System.Drawing.Point(6, 35);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(68, 34);
            this.button7.TabIndex = 31;
            this.button7.Text = "جستجو";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.SearchOreder_Click);
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button8.Location = new System.Drawing.Point(204, 106);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(80, 34);
            this.button8.TabIndex = 32;
            this.button8.Text = "بروزرسانی";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.RefreshOrder_Click);
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
            this.txtdate.Location = new System.Drawing.Point(80, 35);
            this.txtdate.Margin = new System.Windows.Forms.Padding(4);
            this.txtdate.Name = "txtdate";
            this.txtdate.RightToLeftLayout = true;
            this.txtdate.ShowClearButton = false;
            this.txtdate.Size = new System.Drawing.Size(124, 28);
            this.txtdate.TabIndex = 251;
            this.txtdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtdate.TextWhenClearButtonClicked = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.txtdate);
            this.groupBox2.Location = new System.Drawing.Point(522, 672);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 81);
            this.groupBox2.TabIndex = 252;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جستجو دقیق";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 253;
            this.label3.Text = "قیمت کل:";
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(423, 701);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(93, 34);
            this.button9.TabIndex = 254;
            this.button9.Text = "ثبت معمولی";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.RegisterNor_Click);
            // 
            // stiReport6
            // 
            this.stiReport6.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReport6.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiReport6.ReportAlias = "Report";
            this.stiReport6.ReportGuid = "d3d80bf67f3548a6a3ce4c96a6baa703";
            this.stiReport6.ReportName = "Report";
            this.stiReport6.ReportSource = resources.GetString("stiReport6.ReportSource");
            this.stiReport6.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.stiReport6.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReport6.UseProgressInThread = false;
            // 
            // txt1s
            // 
            this.txt1s.Location = new System.Drawing.Point(320, 15);
            this.txt1s.Name = "txt1s";
            this.txt1s.Size = new System.Drawing.Size(100, 24);
            this.txt1s.TabIndex = 255;
            // 
            // txt2gh
            // 
            this.txt2gh.Location = new System.Drawing.Point(219, 12);
            this.txt2gh.Mask = "0000000000000000";
            this.txt2gh.Name = "txt2gh";
            this.txt2gh.Size = new System.Drawing.Size(97, 24);
            this.txt2gh.TabIndex = 256;
            // 
            // txt3ghth
            // 
            this.txt3ghth.Location = new System.Drawing.Point(116, 12);
            this.txt3ghth.Mask = "0000000000000000";
            this.txt3ghth.Name = "txt3ghth";
            this.txt3ghth.Size = new System.Drawing.Size(97, 24);
            this.txt3ghth.TabIndex = 257;
            // 
            // txt4h
            // 
            this.txt4h.Location = new System.Drawing.Point(10, 12);
            this.txt4h.Name = "txt4h";
            this.txt4h.Size = new System.Drawing.Size(100, 24);
            this.txt4h.TabIndex = 258;
            // 
            // group
            // 
            this.group.Controls.Add(this.txt1s);
            this.group.Controls.Add(this.txt4h);
            this.group.Controls.Add(this.txt2gh);
            this.group.Controls.Add(this.txt3ghth);
            this.group.Location = new System.Drawing.Point(306, 770);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(427, 39);
            this.group.TabIndex = 259;
            this.group.TabStop = false;
            this.group.Text = "اطلاعات";
            // 
            // FormListOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.group);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.txtmask);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GridOrder);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormListOrder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "لیست ثبت سفارش";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormListOrder_Load);
            this.Click += new System.EventHandler(this.Search_Click);
            ((System.ComponentModel.ISupportInitialize)(this.GridClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridOrder)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridView GridOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.MaskedTextBox txtCode;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.MaskedTextBox txtmask;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private BehComponents.DateTimePickerX txtdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button button9;
        private Stimulsoft.Report.StiReport stiReport6;
        private System.Windows.Forms.TextBox txt1s;
        private System.Windows.Forms.MaskedTextBox txt2gh;
        private System.Windows.Forms.MaskedTextBox txt3ghth;
        private System.Windows.Forms.TextBox txt4h;
        private System.Windows.Forms.GroupBox group;
    }
}