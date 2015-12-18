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
    public partial class frmFavourite : Form
    {
        bool closeFlag = false;
        int closeCount = 0;
        bool SliderOpen = false;
        int newWidth = 1;
        int ScreenHeight = 0;
        int ScreenWidth = 0;
        public frmFavourite()
        {
            InitializeComponent();
        }

        private void frmIndex_Load(object sender, EventArgs e)
        {
            setFullScreen();
            setMainPanelPosition();
            setRightPamelFullHeight();
            this.Opacity = 0.0;
            frmOpacity.Enabled = true;
            frmOpacity.Start();
            BookingCheck.Enabled = true;
            BookingCheck.Start();
            show_all_menu();
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
            int tX=(Width-title.Width)/2;
            int SideY = (pnlTop.Height - pnlRightCenter.Height+100) / 2;
            int pnlRightHideX = Width - pnlRightHide.Width;
            pnlMain.Location = new Point(mX, mY);
            pnlRightCenter.Location = new Point(0, SideY);
            pnlRightHide.Location = new Point(pnlRightHideX, 0);
            copyright.Location = new Point(lX, lY-70);
            title.Location = new Point(tX, pnlMain.Location.Y-title.Height);
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
            frmIndex n = new frmIndex();
            n.Show();
            closeCount = 0;
            closeFlag = true;
            frmClose.Enabled = true;
            frmClose.Start();
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                foodPic.ImageLocation = path + "\\Image\\" + row.Cells[5].Value.ToString();
                food_id.Text = "" + row.Cells[0].Value.ToString();
                name.Text = " "+row.Cells[1].Value.ToString();
                description.Text =" "+ row.Cells[2].Value.ToString();
                price.Text = " "+row.Cells[3].Value.ToString();
                cookingTime.Text =" "+ row.Cells[4].Value.ToString();
            }
        }

        private void quantity_TextChanged(object sender, EventArgs e)
        {
            int quantityValue = 0;
            int priceValue = 0;
            if (!(quantity.Text).Equals("")) {
                quantityValue = Convert.ToInt32(quantity.Text);
            }
            if (!(price.Text).Equals(""))
            {
                priceValue = Convert.ToInt32(price.Text);
            }
            amount.Text = "" + (quantityValue * priceValue);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (Seat_OR_Not() ==0)
            {
                MessageBox.Show("Please, At first select a table!");
            }
            else {
                if (quantity.Text.Equals(""))
                {
                    MessageBox.Show("Please, Enter your quantity!");
                }
                else { 
                //here is main code for order
                    Popular_count();
                    string main_user=getEmail();
                    string user=getTable();
                    string connStr = "server=localhost;user=root;database=ra;password=;";
                    if (getEmail().Equals("")) {
                        main_user = "Guest";
                    }
                    MySqlConnection conn = new MySqlConnection(connStr);
                   // string sql2 = "insert into favourite (food_id,c_id) values ('" + food_id.Text + "','" + getEmail() + "')";
                    string sql = "insert into food_order (food_id,c_id,quantity,price,message,who) values ('"
                        + food_id.Text + "','" + main_user + "','" + quantity.Text + "','" + amount.Text + "','" +
                        message.Text+ "','"+user+"')";
                    try
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Order successfully...");
                        if (getCountDownCode() == 0) {
                            string sql2 = "insert into waiting_quque (id) values ('"
                                            + user + "')";
                            using (MySqlCommand cmd2 = new MySqlCommand(sql2, conn))
                            {
                                cmd2.ExecuteNonQuery();
                                conn.Close();
                            }
                            sendValueForCountDownFlag();
                            CountDown n = new CountDown();
                            n.Show(this);
                            
                        }
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        MessageBox.Show("Error: " + ex);
                    }
                }
            }
        }
        public void sendValueForCountDownFlag()
        {
            try
            {
                FileReadWrite frw = new FileReadWrite();
                // 1 means running
                string str = frw.getEmailValueString() + "1"; ;
              //  MessageBox.Show("" + str);
                frw.putEmailValueString(str);
                ///MessageBox.Show("" + str);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        public int getCountDownCode()
        {// if return 0 thats means not open
            try
            {
                FileReadWrite frw = new FileReadWrite();
                string[] str = frw.getEmailValueString().Split('$');
                return Convert.ToInt32(str[4]);

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return 0;

            }
        }
        public void Popular_count() {
            string connStr = "server=localhost;user=root;database=ra;password=;";
            MySqlConnection conn = new MySqlConnection(connStr);

            string sql = "UPDATE menu SET totalorder='" + Old_count() + "' where Id='" + food_id.Text + "' ";

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
        }
        public int Old_count(){
        string connStr = "server=localhost;user=root;database=ra;password=;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM menu where Id='" + food_id.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                using (MySqlDataReader rdr = cmd.ExecuteReader())
                {
                    if (rdr.Read())
                    {
                        int temp=Convert.ToInt32(rdr.GetString(7));
                        //MessageBox.Show("Error: " + temp);
                        return temp+1;
                    }
                    else {
                        return 0;
                    }
                }
            }
        }
        public int Seat_OR_Not()
        {
            try
            {
                FileReadWrite frw = new FileReadWrite();
                string[] str = frw.getEmailValueString().Split('$');
                return Convert.ToInt32(str[2]);

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return 0;

            }
        }
        public string getTable()
        {
            try
            {
                FileReadWrite frw = new FileReadWrite();
                //frw.putEmailValueString("1");
               //MessageBox.Show("" + frw.getEmailValueString());
                string[] str = frw.getEmailValueString().Split('$');
               // MessageBox.Show("3=== " + str[4]);
                return str[3];

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return "error";

            }
        }
        private void btnAddFavorite_Click(object sender, EventArgs e)
        {
            if (food_id.Text.Equals("")) {
                MessageBox.Show("Please select items!");
            }
            else if (!Conflict_Check())
            {
                MessageBox.Show("Already remove from favourite list!");
            }else{
                DialogResult dr = MessageBox.Show("Are you sure want to remove from favourite list?", "Confirmation Message",
                                MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    string connStr = "server=localhost;user=root;database=ra;password=;";
                    using (MySqlConnection conn = new MySqlConnection(connStr))
                    {
                        conn.Open();
                        string sql = "DELETE FROM favourite where food_id='" + food_id.Text + "' and c_id='" + getEmail() + "'";
                        using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.ExecuteNonQuery();
                            show_all_menu();
                            MessageBox.Show("Remove from favourite list!");
                        }
                    }
                }
            }
        }
        public int getLogInCode()
        {
            try
            {
                FileReadWrite frw = new FileReadWrite();
                string[] str = frw.getEmailValueString().Split('$');
                return Convert.ToInt32(str[1]);

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return 0;

            }
        }
        private bool Conflict_Check()
        {
            string connStr = "server=localhost;user=root;database=ra;password=;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM favourite where food_id='" + food_id.Text + "' and c_id='"+getEmail()+"'";
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
        private void btnAll_Click(object sender, EventArgs e)
        {
            //DataTable DT = (DataTable)dataGridView1.DataSource;
            //if (DT != null)
             //   DT.Clear();
            show_all_menu();
            
        }

        private void show_all_menu()
        {
            string MyConString = "SERVER=localhost;" +
                                 "DATABASE=ra;" +
                                 "UID=root;" +
                                 "PASSWORD=;";
            try
            {
                string query = "SELECT Id,Name,Description,Price,CookingTime,Image FROM menu where Id IN ("+getFavID()+");";
                //MessageBox.Show(query);
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

        
        public string getFavID()
        {
            List<string> favID = new List<string>();
            string MyConString = "SERVER=localhost;" +
                                 "DATABASE=ra;" +
                                 "UID=root;" +
                                 "PASSWORD=;";
            string favIDstring = "0";
            try
            {
                string query = "SELECT food_id from favourite where c_id='" + getEmail() + "'";
                MySqlConnection con = new MySqlConnection(MyConString);
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    favID.Add(reader.GetString("food_id"));
                }
                favIDstring = string.Join(",", favID);
               // MessageBox.Show("" + favIDstring);
                return favIDstring;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eorrors ocurs: " + ex);
                return favIDstring;
            }

        }

//end
    }
}
