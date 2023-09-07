namespace jxdb_management
{
    partial class Nap
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
            textBoxAccount = new TextBox();
            textBoxVND = new TextBox();
            textBoxKimPhieu = new TextBox();
            buttonConfirm = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Title = new Label();
            SuspendLayout();
            // 
            // textBoxAccount
            // 
            textBoxAccount.Location = new Point(146, 91);
            textBoxAccount.Name = "textBoxAccount";
            textBoxAccount.PlaceholderText = " Tài Khoản Cần Nạp";
            textBoxAccount.Size = new Size(224, 23);
            textBoxAccount.TabIndex = 0;
            // 
            // textBoxVND
            // 
            textBoxVND.Location = new Point(146, 135);
            textBoxVND.Name = "textBoxVND";
            textBoxVND.PlaceholderText = " Số Tiền VND";
            textBoxVND.Size = new Size(224, 23);
            textBoxVND.TabIndex = 1;
            // 
            // textBoxKimPhieu
            // 
            textBoxKimPhieu.Location = new Point(146, 180);
            textBoxKimPhieu.Name = "textBoxKimPhieu";
            textBoxKimPhieu.PlaceholderText = " Số Kim Phiếu";
            textBoxKimPhieu.Size = new Size(224, 23);
            textBoxKimPhieu.TabIndex = 2;
            // 
            // buttonConfirm
            // 
            buttonConfirm.BackColor = Color.GreenYellow;
            buttonConfirm.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonConfirm.ForeColor = Color.Orange;
            buttonConfirm.Location = new Point(178, 267);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(109, 43);
            buttonConfirm.TabIndex = 4;
            buttonConfirm.Text = "Xác Nhận";
            buttonConfirm.UseVisualStyleBackColor = false;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(146, 225);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(39, 19);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Bò";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(209, 225);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(45, 19);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "Bão";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(274, 225);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(46, 19);
            radioButton3.TabIndex = 7;
            radioButton3.TabStop = true;
            radioButton3.Text = "Xốp";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(12, 225);
            label1.Name = "label1";
            label1.Size = new Size(109, 17);
            label1.TabIndex = 8;
            label1.Text = "Admin thực hiện: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(12, 136);
            label2.Name = "label2";
            label2.Size = new Size(51, 17);
            label2.TabIndex = 9;
            label2.Text = "Số tiền:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(12, 92);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 10;
            label3.Text = "Tài khoản:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(12, 181);
            label4.Name = "label4";
            label4.Size = new Size(69, 17);
            label4.TabIndex = 11;
            label4.Text = "Kim phiếu:";
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Brush Script MT", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Title.ForeColor = Color.Lime;
            Title.Location = new Point(98, 9);
            Title.Name = "Title";
            Title.Size = new Size(272, 59);
            Title.TabIndex = 12;
            Title.Text = "JX2 Loan The";
            // 
            // Nap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(474, 322);
            Controls.Add(Title);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(buttonConfirm);
            Controls.Add(textBoxKimPhieu);
            Controls.Add(textBoxVND);
            Controls.Add(textBoxAccount);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Nap";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nạp Kim Phiếu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAccount;
        private TextBox textBoxVND;
        private TextBox textBoxKimPhieu;
        private Button buttonConfirm;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label Title;
    }
}