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
    public partial class frmProfile: Form
    {
        private int closeCount=0;
        private bool closeFlag=false;
        public frmProfile()
        {
            InitializeComponent();
        }

        private void frmIndex_Load(object sender, EventArgs e)
        {
            showALL();
            setFullScreen();
            setMainPanelPosition();
            this.Opacity = 0.0;
            frmOpacity.Enabled = true;
            frmOpacity.Start();
        }

        private void setMainPanelPosition()
        {
            int mX = (Width - pnlMain.Width) / 2;
            int mY = (Height - pnlMain.Height) / 2;
            pnlMain.Location = new Point(mX, mY);
        }

        private void setFullScreen()
        {
            int x = Screen.PrimaryScreen.Bounds.Width;
            int y = Screen.PrimaryScreen.Bounds.Height;
            Location = new Point(0, 0);
            Size = new Size(x, y);
        }

        private void appExit(object sender, EventArgs e)
        {

        }

        private void Exit_leave(object sender, EventArgs e)
        {

        }

        private void Exit_hover(object sender, EventArgs e)
        {

        }

        private void btnBack(object sender, EventArgs e)
        {
            frmChefIndex n = new frmChefIndex();
            n.Show();
            closeFlag = true;
            frmClose.Enabled = true;
            frmClose.Start();
        }

        private void btnBack_hover(object sender, EventArgs e)
        {
            pnlBack.BackColor = Color.FromArgb(0, 240, 240);
        }

        private void btnBack_leave(object sender, EventArgs e)
        {
            pnlBack.BackColor = Color.FromArgb(0, 176, 240);
        }

        private void frmOpacity_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 1.0)
            {
                this.Opacity += 0.1;
            }
            else
            {
                frmOpacity.Stop();
            }
        }

        private void btnBrowse(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;database=ra;password=;";
            string sql = "UPDATE userinfo SET Pass='"+npass.Text+"' where Email='" + getEmail() + "' ";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Password Change successfully...");
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void btnBrowse_hover(object sender, EventArgs e)
        {
            pnlBrouse.BackColor = Color.FromArgb(0, 240, 240);
        }

        private void btnBrowse_leave(object sender, EventArgs e)
        {
            pnlBrouse.BackColor = Color.FromArgb(0, 200, 240);
        }

        private void frmClose_Tick(object sender, EventArgs e)
        {
            if (closeCount == 2 && closeFlag)
            {
                closeFlag = false;
                frmClose.Stop();
                this.Hide();
            }
            else
                closeCount++;
        }
        public string getEmail()
        {
            try
            {
                FileReadWrite frw = new FileReadWrite();
                //frw.putEmailValueString("1");
                string[] str = frw.getEmailValueString().Split('$');
                return str[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return "error";

            }
        }
        public void showALL()
        {
            string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            string connStr = "server=localhost;user=root;database=ra;password=;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM userinfo where Email='" + getEmail() + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                using (MySqlDataReader rdr = cmd.ExecuteReader())
                {
                    /// MessageBox.Show("okkk"+Email.Text+"=="+Pass.Text);
                    while (rdr.Read())
                    {
                        name.Text = rdr.GetString("Name");
                        email.Text = getEmail();
                        mobile.Text = rdr.GetString("Mobile");
                        pass.Text = rdr.GetString("Pass");
                        //name.Text = rdr.GetString("Image");
                        picProfile.ImageLocation = path + "\\Image\\" + rdr.GetString("Image");
                    }
                }
            }
        }

        private void pnlBack_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlBrouse_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
