namespace jxdb_management
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            button1 = new Button();
            textBoxAccount = new TextBox();
            textBoxNewPass = new TextBox();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.GreenYellow;
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBoxAccount
            // 
            resources.ApplyResources(textBoxAccount, "textBoxAccount");
            textBoxAccount.Name = "textBoxAccount";
            textBoxAccount.KeyPress += textBoxAccount_KeyPress;
            // 
            // textBoxNewPass
            // 
            resources.ApplyResources(textBoxNewPass, "textBoxNewPass");
            textBoxNewPass.Name = "textBoxNewPass";
            textBoxNewPass.KeyPress += textBoxNewPass_KeyPress;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = Color.DarkRed;
            label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.DarkRed;
            label1.Name = "label1";
            // 
            // ChangePassword
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(textBoxNewPass);
            Controls.Add(textBoxAccount);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ChangePassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBoxAccount;
        private TextBox textBoxNewPass;
        private Label label3;
        private Label label1;
    }
}