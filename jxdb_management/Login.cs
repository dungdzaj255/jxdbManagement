using MySql.Data.MySqlClient;
using System.Linq.Expressions;
using System.Xml.Serialization;


namespace jxdb_management
{
    public partial class Login : Form
    {
        DatabaseConnection db = new DatabaseConnection();

        public Login()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            string userName = textBoxUsername.Text.ToString();
            string password = textBoxPassword.Text.ToString();


            if (String.IsNullOrEmpty(userName) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username or Password is empty!");
            }
            else
            {
                try
                {
                    db.conn.Open();
                    MySqlCommand cmd = new MySqlCommand("Select * from admin", db.conn);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (userName.Equals(dr.GetString("username")) && password.Equals(dr.GetString("password")))
                        {
                            MainForm main = new MainForm();
                            main.Show();
                            this.Hide();
                            return;
                        }
                    }
                    MessageBox.Show("Login Failed!");
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    db.close_db();
                }
            }
        }
        private void loginButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                loginButton_Click(sender, e);
            }
        }
    }
}