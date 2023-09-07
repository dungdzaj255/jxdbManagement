using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace jxdb_management
{
    internal class DatabaseConnection
    {
        public static string mySqlConn = "server=localhost; user=root; database=paysys; password=12345678";
        public MySqlConnection conn = new MySqlConnection(mySqlConn);

        public bool connect_db()
        {
            try
            {
                conn.Open();
                return true;
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool close_db()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool CheckAccountExist(string account)
        {
            connect_db();
            MySqlCommand cmd = new MySqlCommand("Select * from account", conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (account.Equals(dr.GetString("username")))
                {
                    close_db();
                    return true;
                }
            }
            close_db();
            return false;
        }

        public void NapTien(string account, int vnd, int kimPhieu, string admin)
        {
            bool napthanhcong = false;
            try
            {
                if (CheckAccountExist(account) == false)
                {
                    MessageBox.Show("Tai khoan khong ton tai!");
                    return;
                }
                connect_db();
                MySqlCommand cmd = new MySqlCommand("UPDATE `account` SET `coin` = `coin` + @kimPhieu\n WHERE username = @account", conn);
                cmd.Parameters.AddWithValue("@kimPhieu", kimPhieu);
                cmd.Parameters.AddWithValue("@account", account);
                cmd.ExecuteNonQuery();
                napthanhcong = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                close_db();
            }
            if (napthanhcong)
            {
                LogNap(account, vnd, kimPhieu, admin);
                MessageBox.Show("Nap kim phieu thanh cong!");
            }
            else
            {
                MessageBox.Show("Nap kim phieu that bai!");
                return;
            }
        }

        public void LogNap(string account, int vnd, int kimPhieu, string admin)
        {
            try
            {
                connect_db();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `log_nap`(`account`, `admin`, `danap`, `kimphieu`) VALUES (@account, @admin, @vnd, @kimPhieu)", conn);
                cmd.Parameters.AddWithValue("@kimPhieu", kimPhieu);
                cmd.Parameters.AddWithValue("@account", account);
                cmd.Parameters.AddWithValue("@admin", admin);
                cmd.Parameters.AddWithValue("@vnd", vnd);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Khong the luu lich su nap! " + ex.Message);
            }
            finally
            {
                close_db();
            }
        }

        public void ChangePass(string account, string newPass)
        {
            try
            {
                if (CheckAccountExist(account) == false)
                {
                    MessageBox.Show("Tai khoan khong ton tai!");
                    return;
                }
                connect_db();
                MySqlCommand cmd = new MySqlCommand("UPDATE `account` SET `secpassword`=@password,`password`=@password WHERE `username` = @account", conn);
                cmd.Parameters.AddWithValue("@account", account);
                cmd.Parameters.AddWithValue("@password", newPass);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doi mat khau moi thanh cong!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Doi mat khau that bai! " + ex.Message);
            }
            finally
            {
                close_db();
            }
        }

        public void Change2Pass(string account, string newPass)
        {
            try
            {
                if (CheckAccountExist(account) == false)
                {
                    MessageBox.Show("Tai khoan khong ton tai!");
                    return;
                }
                connect_db();
                MySqlCommand cmd = new MySqlCommand("UPDATE `account` SET `rowpass`=@password WHERE `username` = @account", conn);
                cmd.Parameters.AddWithValue("@account", account);
                cmd.Parameters.AddWithValue("@password", newPass);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doi mat khau moi thanh cong!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Doi mat khau that bai! " + ex.Message);
            }
            finally
            {
                close_db();
            }
        }
        public string GetDoanhThu(DateTime fromDate, DateTime toDate)
        {
            try
            {
                connect_db();
                MySqlCommand cmd = new MySqlCommand("SELECT FORMAT(SUM(`danap`), 'N0') as `doanhthu` FROM `log_nap` WHERE CAST(date AS DATE)  BETWEEN @fromDate AND @toDate", conn);
                cmd.Parameters.AddWithValue("@fromDate", fromDate);
                cmd.Parameters.AddWithValue("@toDate", toDate);
                MySqlDataReader dr = cmd.ExecuteReader();
                string result = "";
                while (dr.Read())
                {
                    result = dr[0].ToString();
                }
                dr.Close();
                if (String.IsNullOrEmpty(result))
                {
                    result = "0";
                }
                return result + " VND";
            }
            catch (Exception ex)
            {
                return "Loi: Khong the lay so lieu! " + ex.Message;
            }
            finally
            {
                close_db();
            }
        }


        public string GetDoanhThuTotal()
        {
            try
            {
                connect_db();
                MySqlCommand cmd = new MySqlCommand("SELECT FORMAT(SUM(`danap`), 'N0') as `doanhthu` FROM `log_nap`", conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                string result = "";
                while (dr.Read())
                {
                    result = dr[0].ToString() + " VND";
                }
                dr.Close();
                return result;
            }
            catch (Exception ex)
            {
                return "Loi: Khong the lay so lieu! " + ex.Message;
            }
            finally
            {
                close_db();
            }
        }

        public string GetPayMost()
        {
            try
            {
                connect_db();
                MySqlCommand cmd = new MySqlCommand("SELECT account, FORMAT(SUM(danap), 'N0')\r\n" +
                                                    "FROM log_nap\r\n" +
                                                    "GROUP BY account\r\n" +
                                                    "ORDER BY SUM(danap) " +
                                                    "DESC\r\n" +
                                                    "LIMIT 1", conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                string result = "";
                while (dr.Read())
                {
                    result = dr[0].ToString() + " - " + dr[1].ToString() + "VND";
                }
                dr.Close();
                return result;
            }
            catch (Exception ex)
            {
                return "Loi: Khong the lay so lieu! " + ex.Message;
            }
            finally
            {
                close_db();
            }
        }

        public string EncryptMD5(string str)
        {
            var calculateHash = EasyEncryption.MD5.ComputeMD5Hash(str);
            return calculateHash;
        }

        public void CopyFirstPay()
        {
            try
            {
                connect_db();
                MySqlCommand cmd = new MySqlCommand("SELECT `account`, MIN(`date`) AS ngay_nap_lan_dau " +
                                                    "FROM log_nap " +
                                                    "GROUP BY `account` ", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    StringBuilder result = new StringBuilder();

                    while (reader.Read())
                    {
                        result.AppendFormat("{0}\n",
                            reader["account"]);
                    }
                    Clipboard.SetText(result.ToString());
                    MessageBox.Show("Copied to clipboard.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: Khong the lay so lieu! " + ex.Message);
            }
            finally
            {
                close_db();
            }
        }
    }
}
