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
    public partial class frmSignUp: Form
    {
        string txt_catagory = null;
        private int closeCount=0;
        private bool closeFlag=false;
        string G_fileName = "";
        string G_fileLocation = "";
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void frmIndex_Load(object sender, EventArgs e)
        {
            setFullScreen();
            setMainPanelPosition();
            this.Opacity = 0.0;
            Type.SelectedIndex = 0;
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
            frmLogin n = new frmLogin();
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
            pnlBrouse.BackColor = Color.FromArgb(0,0,0);
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|JPEG Files (*.jpeg)|*.jpeg";
            ofd.InitialDirectory = @"C:\";
            ofd.Title = "Please select an image file.";
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                string url = ofd.FileName.ToString();
                picProfile.ImageLocation = url;
                ImageName.Text = System.IO.Path.GetFileName(url);
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

        private void btnSubmit(object sender, EventArgs e)
        {
            bool chefFlag = true;
            pnlSubmit.BackColor = Color.FromArgb(0, 0, 0);
            if (RuleTerm.Checked){
                if (Type.Text.Equals("Chef")){
                    DateTime dt = DateTime.Now;
                    string num1 = string.Format("{0:hh}", dt);
                    string num2 = string.Format("{0:d}", dt);
                    string numFinal = num1 + num2;
                    if (SecurityCode.Text.Equals(numFinal))
                    {
                        chefFlag = true;
                    }
                    else {
                        chefFlag = false;
                        MessageBox.Show("Incorrect Security Code!!"+numFinal);                     
                    }
                    
                }
                //here code for insert data
                if(chefFlag){
                    string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    string newFileNmae=DateTime.Now.ToString("yyyyMMddHHmmss")+"_"+ImageName.Text;
                    System.IO.File.Copy(picProfile.ImageLocation, path + "\\image\\" + newFileNmae);
                    string connStr = "server=localhost;user=root;database=ra;password=;";
                    MySqlConnection conn = new MySqlConnection(connStr);

                    string sql = "insert into userinfo (Name,Email,Mobile,Pass,Type,Image) values ('"+name.Text+"','"+email.Text+"','"+mobile.Text+"','"+pass.Text+"','"+Type.Text+"','"+newFileNmae+"')";

                    try
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("You are Registered successfully...");
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        MessageBox.Show("Error: " + ex);
                    }



                }

            }
            else{
                MessageBox.Show("Please checked accept all the rules and terms.");
            }
        }

        private void btnSubmit_hover(object sender, EventArgs e)
        {
            pnlSubmit.BackColor = Color.FromArgb(0, 240, 240);
        }

        private void btnSubmit_leave(object sender, EventArgs e)
        {
            pnlSubmit.BackColor = Color.FromArgb(0, 200, 240);
        }


        private void Security_hide_show()
        {

            txt_catagory = Type.SelectedItem.ToString();
            if (txt_catagory.Equals("Admin") || txt_catagory.Equals("Chef"))
            {
                labSecurityCode.Visible = true;
                SecurityCode.Visible = true;
            }
            else
            {
                labSecurityCode.Visible = false;
                SecurityCode.Visible = false;
            }
        }

        private void comboCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Security_hide_show();
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
    }
}
