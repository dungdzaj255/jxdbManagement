using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace jxdb_management
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string account = textBoxAccount.Text;
            string newPass = textBoxNewPass.Text;
            DatabaseConnection db = new DatabaseConnection();
            if (string.IsNullOrEmpty(account) || string.IsNullOrEmpty(newPass))
            {
                MessageBox.Show("Empty fields!");
                return;
            }
            if (newPass.Length < 6)
            {
                MessageBox.Show("Mat khau chua it nhat 6 ky tu!!");
                return;
            }
            var confirmResult = MessageBox.Show("Ban chac chan muon doi mat khau chu??", "OK Khong!!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                string encryptedPass = db.EncryptMD5(newPass);
                db.ChangePass(account, encryptedPass);
                MainForm form = (MainForm)Application.OpenForms["MainForm"];
                form.refreshForm();
            }
            else
            {
                return;
            }
        }

        private void textBoxNewPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void textBoxAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

    }
}
