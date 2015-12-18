using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Restaurant_Application
{
    public partial class frmOrderReceive : Form
    {
        int reloadCount = 30;
        bool closeFlag = false;
        int closeCount = 0;
        bool SliderOpen = false;
        int newWidth = 1;
        int ScreenHeight = 0;
        int ScreenWidth = 0;
        public frmOrderReceive()
        {
            InitializeComponent();
        }

        private void frmIndex_Load(object sender, EventArgs e)
        {
            show_all_menu();
            show_all_menu2();
            setFullScreen();
            setMainPanelPosition();
            setRightPamelFullHeight();
            this.Opacity = 0.0;
            frmOpacity.Enabled = true;
            frmOpacity.Start();
            BookingCheck.Enabled = true;
            BookingCheck.Start();
            autoLoad.Enabled = true;
            autoLoad.Start();
        }

        private void setRightPamelFullHeight()
        {
            ScreenHeight = Screen.PrimaryScreen.Bounds.Height;
            ScreenWidth = Screen.PrimaryScreen.Bounds.Width;
            pnlRightHide.MaximumSize = new Size(pnlRightHide.Width, ScreenHeight);
            pnlRightHide.Size = new Size(pnlRightHide.Width, ScreenHeight);
            pnlTop.MaximumSize = new Size(pnlTop.Width, ScreenHeight);
            pnlTop.Size = new Size(pnlTop.Width, ScreenHeight);
        }

        private void setMainPanelPosition()
        {
            int mX = (Width - pnlMain.Width) / 2;
            int mY = (Height - pnlMain.Height) / 2;
            int lX = (Width - copyright.Width) / 2;
            int lY = (Height - copyright.Height);
            int SideY = (pnlTop.Height - pnlRightCenter.Height+100) / 2;
            int pnlRightHideX = Width - pnlRightHide.Width;
            pnlMain.Location = new Point(mX, mY);
            pnlRightCenter.Location = new Point(0, SideY);
            pnlRightHide.Location = new Point(pnlRightHideX, 0);
            copyright.Location = new Point(lX, lY-70);
        }

        private void setFullScreen()
        {
            int x = Screen.PrimaryScreen.Bounds.Width;
            int y = Screen.PrimaryScreen.Bounds.Height;
            Location = new Point(0, 0);
            Size = new Size(x, y);
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            pnlRightHide.Visible = false;
            pnlTop.Location = new Point(ScreenWidth, 0);
            pnlTop.Visible = true;
            SliderOpen = true;
            topPnlEffect.Enabled = true;
            topPnlEffect.Start();
        }
        private void CoomonTopMouseLeave()
        {        
        }
        
        private void topPnlEffect_Tick(object sender, EventArgs e)
        {

            if (SliderOpen)
            {
                pnlTop.Location = new Point(ScreenWidth+newWidth, 0);
                newWidth -= 2;
                if (newWidth <=-75)
                {
                    topPnlEffect.Stop();
                }
                SliderClose.Enabled = true;
                SliderClose.Start();
            }
            else
            {
                pnlTop.Location = new Point(ScreenWidth + newWidth, 0);
                newWidth += 2;
                if (newWidth >= 75)
                {
                    topPnlEffect.Stop();
                    pnlTop.Visible = false;
                   
                    pnlRightHide.Visible = true;
                }
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void picLock_Click(object sender, EventArgs e)
        {
            closeFlag = true;
            pnlLock.BackColor = Color.FromArgb(0,190,240);
            frmClose.Enabled = true;
            frmClose.Start();
            SliderClose.Stop();
            autoLoad.Stop();
            frmLogin n = new frmLogin();
            n.Show();
        }

        private void picLock_MouseHover(object sender, EventArgs e)
        {
            pnlLock.BackColor = Color.FromArgb(88, 214, 141);
        }

        private void picLock_MouseLeave(object sender, EventArgs e)
        {
            pnlLock.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            pnlHome.BackColor = Color.FromArgb(0, 190, 240);
        }

        private void picHome_MouseHover(object sender, EventArgs e)
        {
            pnlHome.BackColor = Color.FromArgb(88, 214, 141);
        }

        private void picHome_MouseLeave(object sender, EventArgs e)
        {
            pnlHome.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void picPower_Click(object sender, EventArgs e)
        {
            pnlPower.BackColor = Color.FromArgb(0, 190, 240);
            SliderClose.Stop();
            Application.Exit();
        }

        private void picPower_MouseHover(object sender, EventArgs e)
        {
            pnlPower.BackColor = Color.FromArgb(88, 214, 141);
        }

        private void picPower_MouseLeave(object sender, EventArgs e)
        {
            pnlPower.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void SliderClose_Tick(object sender, EventArgs e)
        {
            int MouseX = Cursor.Position.X;
            if (MouseX <= ScreenWidth-pnlTop.Width)
            {
                SliderOpen = false;
                topPnlEffect.Enabled = true;
                topPnlEffect.Start();
                SliderClose.Stop();
            }
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

        private void picHome_Click_1(object sender, EventArgs e)
        {
            autoLoad.Stop();
            frmChefIndex n = new frmChefIndex();
            n.Show();
            closeCount = 0;
            closeFlag = true;
            frmClose.Enabled = true;
            frmClose.Start();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT id,food_id,quantity,message,who,status FROM food_order where status='0';";
            if (search.Text.Length != 0)
            {
                query = "SELECT id,food_id,quantity,message,who,status FROM food_order where who like '%" + search.Text + "%' and status='0';";
            }
            else if (search.Text.Length == 0)
            {
                show_all_menu();
            }
            string MyConString = "SERVER=localhost;" +
                                 "DATABASE=ra;" +
                                 "UID=root;" +
                                 "PASSWORD=;";
            try
            {

                MySqlConnection con = new MySqlConnection(MyConString);
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);
                MySqlDataAdapter dataAdp = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                //dataGridView1.RowTemplate.Height = 120;
                dataGridView1.AllowUserToAddRows = false;
                dataAdp.Fill(dt);
                dataGridView1.DataSource = dt;
                dataAdp.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eorrors ocurs: " + ex);
            }
        }
        private void show_all_menu()
        {
            string MyConString = "SERVER=localhost;" +
                                 "DATABASE=ra;" +
                                 "UID=root;" +
                                 "PASSWORD=;";
            try
            {
                string query = "SELECT id,food_id,quantity,message,who,status FROM food_order where status='0';";
                MySqlConnection con = new MySqlConnection(MyConString);
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);
                MySqlDataAdapter dataAdp = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                //dataGridView1.RowTemplate.Height = 120;
                dataGridView1.AllowUserToAddRows = false;
                dataAdp.Fill(dt);
                dataGridView1.DataSource = dt;
                dataAdp.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eorrors ocurs: " + ex);
            }
        }
        private void show_all_menu2()
        {
            string MyConString = "SERVER=localhost;" +
                                 "DATABASE=ra;" +
                                 "UID=root;" +
                                 "PASSWORD=;";
            try
            {
                string query = "SELECT id,food_id,quantity,message,who,status FROM food_order where status='1';";
                MySqlConnection con = new MySqlConnection(MyConString);
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);
                MySqlDataAdapter dataAdp = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();

                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                //dataGridView1.RowTemplate.Height = 120;
                dataGridView2.AllowUserToAddRows = false;
                dataAdp.Fill(dt);
                dataGridView2.DataSource = dt;
                dataAdp.Dispose();
                //dataGridView2.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eorrors ocurs: " + ex);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                
                fid.Text = row.Cells[0].Value.ToString();
                string[] arr = getNameImage(row.Cells[1].Value.ToString()).Split('$');
                fname.Text = arr[0];
                quantity.Text = row.Cells[2].Value.ToString();
                msg.Text = row.Cells[3].Value.ToString();
                tb.Text = row.Cells[4].Value.ToString().Substring(16, row.Cells[4].Value.ToString().Length - 16);
                picProfile.ImageLocation = path + "\\Image\\" + arr[1];
                status.SelectedIndex = Convert.ToInt32(row.Cells[5].Value.ToString());
            }
        }
        private string getNameImage(string foodID)
        {
            string connStr = "server=localhost;user=root;database=ra;password=;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM menu where Id='" + foodID + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                using (MySqlDataReader rdr = cmd.ExecuteReader())
                {
                    /// MessageBox.Show("okkk"+Email.Text+"=="+Pass.Text);
                    while (rdr.Read())
                    {
                        //MessageBox.Show("okkk");
                        return rdr.GetString("Name")+"$"+rdr.GetString("Image");
                    }
                }
            }
            return "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            show_all_menu();
            show_all_menu2();
            reloadCount = 30;
            txtReloadCounter.Text = String.Format("{0:00}", reloadCount);
        }

        private void autoLoad_Tick(object sender, EventArgs e)
        {
            if (reloadCount == 0)
            {
                show_all_menu();
                show_all_menu2();
                reloadCount = 30;
            }
            else {
                reloadCount--;
            }
            txtReloadCounter.Text = String.Format("{0:00}",reloadCount);
        }

        private void search2_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT id,food_id,quantity,message,who,status FROM food_order where status='1';";
            if (search.Text.Length != 0)
            {
                query = "SELECT id,food_id,quantity,message,who,status FROM food_order where who like '%" + search.Text + "%' and status='1';";
            }
            else if (search.Text.Length == 0)
            {
                show_all_menu2();
            }
            string MyConString = "SERVER=localhost;" +
                                 "DATABASE=ra;" +
                                 "UID=root;" +
                                 "PASSWORD=;";
            try
            {

                MySqlConnection con = new MySqlConnection(MyConString);
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);
                MySqlDataAdapter dataAdp = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();

                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                //dataGridView1.RowTemplate.Height = 120;
                dataGridView2.AllowUserToAddRows = false;
                dataAdp.Fill(dt);
                dataGridView2.DataSource = dt;
                dataAdp.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eorrors ocurs: " + ex);
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

                fid.Text = row.Cells[0].Value.ToString();
                string[] arr = getNameImage(row.Cells[1].Value.ToString()).Split('$');
                fname.Text = arr[0];
                quantity.Text = row.Cells[2].Value.ToString();
                msg.Text = row.Cells[3].Value.ToString();
                tb.Text = row.Cells[4].Value.ToString().Substring(16, row.Cells[4].Value.ToString().Length-16);
                picProfile.ImageLocation = path + "\\Image\\" + arr[1];
                status.SelectedIndex = Convert.ToInt32(row.Cells[5].Value.ToString());
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;database=ra;password=;";
            string sql = "UPDATE food_order SET status='"+status.SelectedIndex+"' where id='" + fid.Text + "' ";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.ExecuteNonQuery();
                        show_all_menu();
                        show_all_menu2();
                    }
                    conn.Close();
                }
            }
            catch (Exception exx)
            {
                MessageBox.Show("" + exx);
            }
        }


    }
}
