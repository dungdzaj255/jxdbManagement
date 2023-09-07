using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace jxdb_management
{
    public partial class Nap : Form
    {
        DatabaseConnection db = new DatabaseConnection();

        public Nap()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string account = textBoxAccount.Text.ToString();
            string rawVnd = textBoxVND.Text.ToString();
            string rawKimPhieu = textBoxKimPhieu.Text.ToString();
            string admin = checkAdmin();
            if (String.IsNullOrEmpty(account) || String.IsNullOrEmpty(rawVnd) || String.IsNullOrEmpty(rawKimPhieu) || String.IsNullOrEmpty(admin))
            {
                MessageBox.Show("Empty fields!");
                return;
            }
            if (int.TryParse(rawVnd, out int vnd) && int.TryParse(rawKimPhieu, out int kimPhieu))
            {
                var confirmResult = MessageBox.Show("Xac nhan nap tien vao tai khoan " + account + " ?", "OK Khong!!", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    db.NapTien(account, vnd, kimPhieu, admin);
                    MainForm form = (MainForm)Application.OpenForms["MainForm"];
                    form.refreshForm();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Nhap tien so!");
                return;
            }

        }

        private string checkAdmin()
        {
            if (radioButton1.Checked == true)
            {
                return "Bò";
            }
            else if (radioButton2.Checked == true)
            {
                return "Bão";
            }
            else if (radioButton3.Checked == true)
            {
                return "Xốp";
            }
            else
            {
                return "";
            }
        }
    }
}
