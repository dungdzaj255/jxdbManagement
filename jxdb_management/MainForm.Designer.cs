namespace jxdb_management
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            buttonDecrypt = new Button();
            textBoxDecrypt = new TextBox();
            Author = new Label();
            Search = new Button();
            textBoxSearch = new TextBox();
            dataAccount = new DataGridView();
            ChangePassword = new Button();
            tabPage2 = new TabPage();
            buttonNap = new Button();
            buttonFirstPay = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            textBoxDoanhThu = new TextBox();
            label5 = new Label();
            label2 = new Label();
            textBoxPayMost = new TextBox();
            textBoxDoanhThu2 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            dataLogPay = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataAccount).BeginInit();
            tabPage2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataLogPay).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-1, 0);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1449, 913);
            tabControl1.SizeMode = TabSizeMode.FillToRight;
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(buttonDecrypt);
            tabPage1.Controls.Add(textBoxDecrypt);
            tabPage1.Controls.Add(Author);
            tabPage1.Controls.Add(Search);
            tabPage1.Controls.Add(textBoxSearch);
            tabPage1.Controls.Add(dataAccount);
            tabPage1.Controls.Add(ChangePassword);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1441, 880);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Quản lý tài khoản";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonDecrypt
            // 
            buttonDecrypt.ImeMode = ImeMode.NoControl;
            buttonDecrypt.Location = new Point(38, 811);
            buttonDecrypt.Name = "buttonDecrypt";
            buttonDecrypt.Size = new Size(102, 35);
            buttonDecrypt.TabIndex = 7;
            buttonDecrypt.Text = "Encrypt";
            buttonDecrypt.UseVisualStyleBackColor = true;
            buttonDecrypt.Click += buttonDecrypt_Click;
            // 
            // textBoxDecrypt
            // 
            textBoxDecrypt.Location = new Point(156, 815);
            textBoxDecrypt.Name = "textBoxDecrypt";
            textBoxDecrypt.Size = new Size(349, 27);
            textBoxDecrypt.TabIndex = 6;
            // 
            // Author
            // 
            Author.AutoSize = true;
            Author.Font = new Font("Blackadder ITC", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Author.ForeColor = Color.Blue;
            Author.Location = new Point(1400, 904);
            Author.Name = "Author";
            Author.Size = new Size(143, 23);
            Author.TabIndex = 5;
            Author.Text = "Dev: Dzung Phung";
            // 
            // Search
            // 
            Search.Location = new Point(38, 744);
            Search.Name = "Search";
            Search.Size = new Size(102, 35);
            Search.TabIndex = 2;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = true;
            Search.Click += Search_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(156, 748);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(349, 27);
            textBoxSearch.TabIndex = 1;
            textBoxSearch.KeyPress += searchButton_KeyPress;
            // 
            // dataAccount
            // 
            dataAccount.BackgroundColor = Color.White;
            dataAccount.BorderStyle = BorderStyle.None;
            dataAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataAccount.Location = new Point(0, 0);
            dataAccount.Name = "dataAccount";
            dataAccount.RowHeadersWidth = 51;
            dataAccount.RowTemplate.Height = 29;
            dataAccount.Size = new Size(1441, 704);
            dataAccount.TabIndex = 0;
            // 
            // ChangePassword
            // 
            ChangePassword.BackColor = Color.Lime;
            ChangePassword.Font = new Font("Palatino Linotype", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ChangePassword.ImeMode = ImeMode.NoControl;
            ChangePassword.Location = new Point(728, 730);
            ChangePassword.Name = "ChangePassword";
            ChangePassword.Size = new Size(130, 61);
            ChangePassword.TabIndex = 3;
            ChangePassword.Text = "Đổi Mật Khẩu";
            ChangePassword.UseVisualStyleBackColor = false;
            ChangePassword.Click += ChangePassword_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(buttonNap);
            tabPage2.Controls.Add(buttonFirstPay);
            tabPage2.Controls.Add(tableLayoutPanel1);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(dateTimePicker2);
            tabPage2.Controls.Add(dateTimePicker1);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(dataLogPay);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1441, 880);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Lịch sử nạp";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonNap
            // 
            buttonNap.BackColor = Color.OrangeRed;
            buttonNap.Font = new Font("Palatino Linotype", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonNap.Location = new Point(1117, 380);
            buttonNap.Name = "buttonNap";
            buttonNap.Size = new Size(178, 65);
            buttonNap.TabIndex = 15;
            buttonNap.Text = "Nạp Tiền";
            buttonNap.UseVisualStyleBackColor = false;
            buttonNap.Click += buttonNap_Click;
            // 
            // buttonFirstPay
            // 
            buttonFirstPay.BackColor = Color.LightSalmon;
            buttonFirstPay.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonFirstPay.ForeColor = Color.DarkRed;
            buttonFirstPay.Location = new Point(1117, 484);
            buttonFirstPay.Margin = new Padding(3, 4, 3, 4);
            buttonFirstPay.Name = "buttonFirstPay";
            buttonFirstPay.Size = new Size(178, 65);
            buttonFirstPay.TabIndex = 14;
            buttonFirstPay.Text = "Copy danh sách nạp lần đầu";
            buttonFirstPay.UseVisualStyleBackColor = false;
            buttonFirstPay.Click += buttonFirstPay_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(textBoxDoanhThu, 1, 0);
            tableLayoutPanel1.Controls.Add(label5, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 2, 0);
            tableLayoutPanel1.Controls.Add(textBoxPayMost, 1, 1);
            tableLayoutPanel1.Controls.Add(textBoxDoanhThu2, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(3, 724);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1435, 153);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(6, 23);
            label1.Margin = new Padding(3, 20, 3, 20);
            label1.Name = "label1";
            label1.Size = new Size(224, 32);
            label1.TabIndex = 2;
            label1.Text = "Tổng Doanh Thu:";
            // 
            // textBoxDoanhThu
            // 
            textBoxDoanhThu.BackColor = Color.White;
            textBoxDoanhThu.BorderStyle = BorderStyle.None;
            textBoxDoanhThu.Font = new Font("Cambria", 16F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxDoanhThu.ForeColor = Color.LimeGreen;
            textBoxDoanhThu.Location = new Point(283, 23);
            textBoxDoanhThu.Margin = new Padding(10, 20, 3, 20);
            textBoxDoanhThu.Name = "textBoxDoanhThu";
            textBoxDoanhThu.ReadOnly = true;
            textBoxDoanhThu.ScrollBars = ScrollBars.Horizontal;
            textBoxDoanhThu.Size = new Size(413, 32);
            textBoxDoanhThu.TabIndex = 4;
            textBoxDoanhThu.Click += textBoxDoanThu_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(6, 98);
            label5.Margin = new Padding(3, 20, 3, 20);
            label5.Name = "label5";
            label5.Size = new Size(261, 32);
            label5.TabIndex = 13;
            label5.Text = "Đóng họ nhiều nhất:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(705, 23);
            label2.Margin = new Padding(3, 20, 3, 20);
            label2.Name = "label2";
            label2.Size = new Size(290, 32);
            label2.TabIndex = 11;
            label2.Text = "Doanh Thu Theo Ngày:";
            // 
            // textBoxPayMost
            // 
            textBoxPayMost.BackColor = Color.White;
            textBoxPayMost.BorderStyle = BorderStyle.None;
            textBoxPayMost.Font = new Font("Cambria", 16F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPayMost.ForeColor = Color.LimeGreen;
            textBoxPayMost.Location = new Point(283, 98);
            textBoxPayMost.Margin = new Padding(10, 20, 3, 20);
            textBoxPayMost.Name = "textBoxPayMost";
            textBoxPayMost.ReadOnly = true;
            textBoxPayMost.ScrollBars = ScrollBars.Horizontal;
            textBoxPayMost.Size = new Size(413, 32);
            textBoxPayMost.TabIndex = 14;
            // 
            // textBoxDoanhThu2
            // 
            textBoxDoanhThu2.BackColor = Color.White;
            textBoxDoanhThu2.BorderStyle = BorderStyle.None;
            textBoxDoanhThu2.Font = new Font("Cambria", 16F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxDoanhThu2.ForeColor = Color.Crimson;
            textBoxDoanhThu2.Location = new Point(1011, 23);
            textBoxDoanhThu2.Margin = new Padding(10, 20, 3, 20);
            textBoxDoanhThu2.Name = "textBoxDoanhThu2";
            textBoxDoanhThu2.ReadOnly = true;
            textBoxDoanhThu2.ScrollBars = ScrollBars.Horizontal;
            textBoxDoanhThu2.Size = new Size(303, 32);
            textBoxDoanhThu2.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(1091, 199);
            label4.Name = "label4";
            label4.Size = new Size(74, 17);
            label4.TabIndex = 10;
            label4.Text = "Đến ngày:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(1091, 93);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 9;
            label3.Text = "Từ ngày:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.CustomFormat = "MM/dd/yyyy";
            dateTimePicker2.Location = new Point(1169, 191);
            dateTimePicker2.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(258, 27);
            dateTimePicker2.TabIndex = 7;
            dateTimePicker2.Value = new DateTime(2023, 9, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            dateTimePicker1.Location = new Point(1169, 85);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(258, 27);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.Value = new DateTime(2023, 8, 1, 0, 0, 0, 0);
            // 
            // button1
            // 
            button1.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(1202, 265);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(127, 37);
            button1.TabIndex = 1;
            button1.Text = "LOAD";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataLogPay
            // 
            dataLogPay.BackgroundColor = Color.White;
            dataLogPay.BorderStyle = BorderStyle.None;
            dataLogPay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataLogPay.Location = new Point(0, 0);
            dataLogPay.Name = "dataLogPay";
            dataLogPay.RowHeadersWidth = 51;
            dataLogPay.RowTemplate.Height = 29;
            dataLogPay.Size = new Size(1080, 704);
            dataLogPay.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoValidate = AutoValidate.Disable;
            CausesValidation = false;
            ClientSize = new Size(1445, 908);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DatabaseJX2";
            Load += MainForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataAccount).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataLogPay).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        public DataGridView dataAccount;
        private TabPage tabPage2;
        private Button Search;
        private TextBox textBoxSearch;
        public DataGridView dataLogPay;
        private Button ChangePassword;
        private Button button1;
        private Label Author;
        private Label label1;
        private TextBox textBoxDoanhThu;
        private Button buttonDecrypt;
        private TextBox textBoxDecrypt;
        private TextBox textBoxDoanhThu2;
        private Label label2;
        private Label label4;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label5;
        private TextBox textBoxPayMost;
        private Button buttonFirstPay;
        private Button buttonNap;
    }
}