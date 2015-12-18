using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Application
{
    //0 first value
    //1 user exit
    //2 chef close
    //420 error

    //ordert table
    //0 pending
    //1 cooking
    //2 served
    public partial class CountDown : Form
    {
        int countFlag = 0;
        int m = 0;
        int h = 0;
        int s = 0;
        private static string connStr = "server=localhost;user=root;database=ra;password=;";
        public CountDown()
        {
            InitializeComponent();
            this.TopLevel = true;
            this.TopMost = true;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
        }
        public string getUser()
        {
            try
            {
                FileReadWrite frw = new FileReadWrite();
                string[] str = frw.getEmailValueString().Split('$');
                // MessageBox.Show("3=== " + str[3]);
                return str[3];

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return "error";

            }
        }
        private string getStatus()
        {
            string query = "SELECT * FROM waiting_quque where id='" + getUser() + "';";
            using (MySqlConnection con = new MySqlConnection(connStr))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            return rdr.GetString("status");
                        }
                    }
                }
                con.Close();
            }
            return "420";
        }
        private string foodID()
        {
            string query = "SELECT * FROM food_order where status='3' and who='" + getUser() + "';";
            using (MySqlConnection con = new MySqlConnection(connStr))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            statusChange(rdr.GetString("id"));
                            return rdr.GetString("food_id");
                        }
                    }
                }
                con.Close();
            }
            return "";
        }
        private string statusChange(string id)
        {
            string query = "UPDATE food_order set status='0' where id='" +id + "';";
            using (MySqlConnection con = new MySqlConnection(connStr))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
            return "";
        }
        private void updateDelay(string id)
        {
            string query = "UPDATE waiting_quque set delay='"+txtCountDown.Text+"' where id='" + id + "';";
            using (MySqlConnection con = new MySqlConnection(connStr))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
        }
        private int getCoockingTime(string fID)
        {
            string query = "SELECT * FROM menu where Id='" + fID + "';";
            using (MySqlConnection con = new MySqlConnection(connStr))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            return rdr.GetInt32("CookingTime");
                        }
                    }
                }
                con.Close();
            }
            return 0;
        }
        public int getRowCount()
        {
            string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            string connStr = "server=localhost;user=root;database=ra;password=;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT count(*) FROM food_order where who='" + getUser() + "' and status='2'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                using (MySqlDataReader rdr = cmd.ExecuteReader())
                {
                    /// MessageBox.Show("okkk"+Email.Text+"=="+Pass.Text);
                    while (rdr.Read())
                    {
                        return Convert.ToInt16(rdr[0]);
                    }
                }
            }
            return 0;
        }
        public int getRowCountTotal()
        {
            string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            string connStr = "server=localhost;user=root;database=ra;password=;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT count(*) FROM food_order where who='" + getUser() + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                using (MySqlDataReader rdr = cmd.ExecuteReader())
                {
                    /// MessageBox.Show("okkk"+Email.Text+"=="+Pass.Text);
                    while (rdr.Read())
                    {
                        return Convert.ToInt16(rdr[0]);
                    }
                }
            }
            return 0;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (getStatus().Equals("2"))
            {
                updateDelay(getUser());
                countFlag = 1;
                timer1.Stop();
                this.Hide();
            }
            if (getRowCount() == getRowCountTotal())
            {
                countFlag = 1;
            }
            else {
                countFlag = 0;
            }
            if (countFlag == 0) {
                m = m + getCoockingTime(foodID());


                if (s < 0)
                {
                    s = 0;
                }
                if (m == 0 && s == 0)
                {
                    m--;
                    s = 0;
                }
                else if (s == 0)
                {
                    m--;
                    s = 59;
                }
                else if (s == 59)
                {
                    m--;
                    s = 0;
                }
                if (m < 0)
                {
                    txtCountDown.Text = "- " + String.Format("{0:00}", h) + ":" + String.Format("{0:00}", (-1) * m) + ":" + String.Format("{0:00}", s++);
                }
                else
                {
                    txtCountDown.Text = String.Format("{0:00}", h) + ":" + String.Format("{0:00}", m) + ":" + String.Format("{0:00}", s--);
                }
            }
            
        }

    }
}
