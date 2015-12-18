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
    public partial class frmLogin : Form
    {
        bool closeFlag = false;
        int closeCount = 0;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmIndex_Load(object sender, EventArgs e)
        {
            setFullScreen();
            setMainPanelPosition();
            this.Opacity = 0.0;
            frmLoginOpacity.Enabled = true;
            frmLoginOpacity.Start();
            Type.SelectedIndex = 0;
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
        private void button2_Click(object sender, EventArgs e)
        {
            frmIndex n = new frmIndex();
            n.Show();
            this.Hide();
        }

        private void Exit_hover(object sender, EventArgs e)
        {
            pnlExit.BackColor = Color.FromArgb(0, 240, 240);
        }

        private void Exit_leave(object sender, EventArgs e)
        {
            pnlExit.BackColor = Color.FromArgb(0, 176, 240);
        }
        private void btnForgot_click(object sender, EventArgs e)
        {

        }

        private void btnForgot_hover(object sender, EventArgs e)
        {
            pnlBtnForgot.BackColor = Color.FromArgb(0, 240, 240);
        }

        private void btnForgot_leave(object sender, EventArgs e)
        {
            pnlBtnForgot.BackColor = Color.LightSeaGreen;
        }

        private void btnNewUser_Hover(object sender, EventArgs e)
        {
            pnlNewUser.BackColor = Color.FromArgb(0, 240, 240);
        }

        private void btnNewUser_Leave(object sender, EventArgs e)
        {
            pnlNewUser.BackColor = Color.FromArgb(0, 176, 240);
        }

        private void btnLogin_hover(object sender, EventArgs e)
        {
            pnlLogin.BackColor = Color.FromArgb(0, 240, 240);

        }

        private void btnLogin(object sender, EventArgs e)
        {
            pnlLogin.BackColor = Color.FromArgb(0, 0, 0);
            if (Login_Check())
            {
                if (Type.Text.Equals("Chef"))
                {
                    frmChefIndex n = new frmChefIndex();
                    n.Show();
                    closeFlag = true;
                }
                else
                {
                    frmIndex n = new frmIndex();
                    n.Show();
                    closeFlag = true;
                }
                sendValueForLogin();
                frmClose.Start();
            }
            else {
                errMsg.Text = "Email and Password incorrect!!";
            }

        }

        private void btnLogin_leave(object sender, EventArgs e)
        {
            pnlLogin.BackColor = Color.FromArgb(0, 176, 240);
        }

        private void btnGuestLogin(object sender, EventArgs e)
        {
            Email.Text = "";
            sendValueForLoginGuest();
            frmIndex n = new frmIndex();
            n.Show();
            closeFlag = true;
            frmClose.Start();
        }

        private void sendValueForLoginGuest()
        {
            try
            {
                FileReadWrite frw = new FileReadWrite();
                frw.putEmailValueString(Email.Text + "$0$0");
                //MessageBox.Show(""+frw.getEmailValueString().Substring(0,frw.getEmailValueString().Length-2));
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void btnGuestLogin_hover(object sender, EventArgs e)
        {
            pnlGuest.BackColor = Color.FromArgb(0, 240, 240);
        }

        private void btnGuestLogin_leave(object sender, EventArgs e)
        {
            pnlGuest.BackColor = Color.FromArgb(0, 176, 240);
        }

        private void btnExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNewUser(object sender, EventArgs e)
        {
            frmSignUp n = new frmSignUp();
            n.Show();
            closeFlag = true;
            frmClose.Start();
        }

        private void frmClose_Tick(object sender, EventArgs e)
        {
            if (closeCount >= 2 && closeFlag)
            {
                closeCount = 0;
                closeFlag = false;
                frmClose.Stop();
                this.Hide();
            }
            else
                closeCount++;

        }

        private void frmLoginOpacity_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 1.0)
            {
                this.Opacity += 0.1;
            }
            else
            {
                frmLoginOpacity.Stop();
            }
        }
        private bool Login_Check()
        {
            string connStr = "server=localhost;user=root;database=ra;password=;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM userinfo where Email='" + Email.Text + "' and Pass='" + Pass.Text + "' and Type='" + Type.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                using (MySqlDataReader rdr = cmd.ExecuteReader())
                {
                   /// MessageBox.Show("okkk"+Email.Text+"=="+Pass.Text);
                    while (rdr.Read())
                    {
                        //MessageBox.Show("okkk");
                        return true;
                    }
                }
            }
            return false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
                string connStr = "server=localhost;user=root;database=ra;password=;";
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "SELECT * FROM userinfo where Email='" + lostEmail.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            this.TopMost = false;
                            errMsg.Text = "";
                           // MessageBox.Show("your password is: " + rdr.GetString("Pass"));
                            string message = "Your email is           : " + lostEmail.Text + "\n" + 
                                             "Your forgot password is : " + rdr.GetString("Pass") + "\nThank you!\n\n\n\t\t" +
                                             "Powered by RedHeX.";
                            Mailer_func m = new Mailer_func();
                            m.SendEmail(lostEmail.Text, "Restaurant Application", message);
                        }
                        else
                        {
                            errMsg.Text = "Not Found!..";
                        }
                    }
                }
        }
        private void sendValueForLogin()
        {
            try
            {
                FileReadWrite frw = new FileReadWrite();
                frw.putEmailValueString(Email.Text+"$1$0");
                //MessageBox.Show(""+frw.getEmailValueString().Substring(0,frw.getEmailValueString().Length-2));
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
    }
}
