using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace jxdb_management
{
    public partial class MainForm : Form
    {
        DatabaseConnection db = new DatabaseConnection();
        public MainForm()
        {
            InitializeComponent();
            dateTimePicker2.Value = DateTime.Today;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loadData(textBoxSearch.Text.ToString());
            LoadLogPay(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
            textBoxDoanhThu.Text = db.GetDoanhThuTotal();
            textBoxDoanhThu2.Text = db.GetDoanhThu(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
            textBoxPayMost.Text = db.GetPayMost();
        }

        public void LoadLogPay(DateTime fromDate, DateTime toDate)
        {
            string querry = "SELECT `account` as `Tai Khoan`, FORMAT(`danap`, 'N0') as `VND`, FORMAT(`kimphieu`, 'N0') as `Kim Phieu`, `admin` as `Admin`, `date` as `Thoi Gian Nap` FROM `log_nap` WHERE CAST(`date` AS DATE) BETWEEN @fromDate AND @toDate ORDER BY `Thoi Gian Nap` ASC";
            MySqlCommand mySqlCommand = new MySqlCommand(querry, db.conn);
            mySqlCommand.Parameters.AddWithValue("@fromDate", fromDate);
            mySqlCommand.Parameters.AddWithValue("@toDate", toDate);

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = mySqlCommand;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dt;

            dataLogPay.DataSource = bindingSource;
            dataLogPay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            db.close_db();
        }

        public void loadData(string search)
        {
            string querry = "SELECT username as `Tai Khoan`, password as 'Mat khau cap 1', rowpass as 'Mat khau cap 2', security_questions.question as 'Cau hoi', answer as 'Cau tra loi', " +
                            "full_name as `Ten`, created_on  as `Ngay Tao` " +
                            "FROM account " +
                            "JOIN security_questions ON security_questions.id = account.question " +
                            "WHERE username LIKE '%" + search + "%'";
            MySqlCommand mySqlCommand = new MySqlCommand(querry);
            mySqlCommand.Connection = db.conn;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = mySqlCommand;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dt;

            dataAccount.DataSource = bindingSource;
            dataAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            db.close_db();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            loadData(textBoxSearch.Text.ToString());
        }

        private void searchButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                Search_Click(sender, e);
            }
        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword changepass = new ChangePassword();
            changepass.ShowDialog();
        }

        private void buttonNap_Click(object sender, EventArgs e)
        {
            Nap nap = new Nap();
            nap.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refreshForm();
        }

        private void textBoxDoanThu_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxDoanhThu.Text, TextDataFormat.Text);
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            string decryptedStr = db.EncryptMD5(textBoxDecrypt.Text);
            textBoxDecrypt.Text = decryptedStr;
        }

        private void buttonFirstPay_Click(object sender, EventArgs e)
        {
            db.CopyFirstPay();
        }

        public void refreshForm()
        {
            loadData(textBoxSearch.Text.ToString());
            LoadLogPay(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
            textBoxDoanhThu.Text = db.GetDoanhThuTotal();
            textBoxDoanhThu2.Text = db.GetDoanhThu(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
            textBoxPayMost.Text = db.GetPayMost();
        }
    }
}
