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
    public partial class frmTable : Form
    {
        bool closeFlag = false;
        bool bookingConflictFlag = false;
        int closeCount = 0;
        bool SliderOpen = false;
        int newWidth = 1;
        int ScreenHeight = 0;
        int ScreenWidth = 0;
        public frmTable()
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
            BookingCheck.Stop();
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
            BookingCheck.Stop();
            closeFlag = true;
            frmClose.Enabled = true;
            frmClose.Start();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Red;
            if (Table_book("table1"))
            {
                MessageBox.Show("Alredy booked.Try another one!");
            }
            else {
                Table_booking("table1");
            }
        } 

        private void panel1_MouseHover_1(object sender, EventArgs e)
        {
            panel1.BackColor = Color.MediumSpringGreen;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Black;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Red;
            if (Table_book("table2"))
            {
                MessageBox.Show("Alredy booked.Try another one!");
            }
            else
            {
                Table_booking("table2");
            }
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            panel2.BackColor = Color.MediumSpringGreen;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Black;
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Red;
            if (Table_book("table3"))
            {
                MessageBox.Show("Alredy booked.Try another one!");
            }
            else
            {
                Table_booking("table3");
            }
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            panel3.BackColor = Color.MediumSpringGreen;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Black;
        }

        private void panel4_MouseHover(object sender, EventArgs e)
        {
            panel4.BackColor = Color.MediumSpringGreen;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Black;
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Red;
            if (Table_book("table4"))
            {
                MessageBox.Show("Alredy booked.Try another one!");
            }
            else
            {
                Table_booking("table4");
            }
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            panel5.BackColor = Color.Red;
            if (Table_book("table5"))
            {
                MessageBox.Show("Alredy booked.Try another one!");
            }
            else
            {
                Table_booking("table5");
            }
        }

        private void panel5_MouseHover(object sender, EventArgs e)
        {
            panel5.BackColor = Color.MediumSpringGreen;
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = Color.Black;
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            panel6.BackColor = Color.Red;
            if (Table_book("table6"))
            {
                MessageBox.Show("Alredy booked.Try another one!");
            }
            else
            {
                Table_booking("table6");
            }
        }

        private void panel6_MouseHover(object sender, EventArgs e)
        {
            panel6.BackColor = Color.MediumSpringGreen;
        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackColor = Color.Black;
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            panel7.BackColor = Color.Red;
            if (Table_book("table7"))
            {
                MessageBox.Show("Alredy booked.Try another one!");
            }
            else
            {
                Table_booking("table7");
            }
        }

        private void panel7_MouseHover(object sender, EventArgs e)
        {
            panel7.BackColor = Color.MediumSpringGreen;
        }

        private void panel7_MouseLeave(object sender, EventArgs e)
        {
            panel7.BackColor = Color.Black;
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            panel8.BackColor = Color.Red;
            if (Table_book("table8"))
            {
                MessageBox.Show("Alredy booked.Try another one!");
            }
            else
            {
                Table_booking("table8");
            }
        }

        private void panel8_MouseHover(object sender, EventArgs e)
        {
            panel8.BackColor = Color.MediumSpringGreen;
        }

        private void panel8_MouseLeave(object sender, EventArgs e)
        {
            panel8.BackColor = Color.Black;
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            panel9.BackColor = Color.Red;
            if (Table_book("table9"))
            {
                MessageBox.Show("Alredy booked.Try another one!");
            }
            else
            {
                Table_booking("table9");
            }
        }

        private void panel9_MouseHover(object sender, EventArgs e)
        {
            panel9.BackColor = Color.MediumSpringGreen;
        }

        private void panel9_MouseLeave(object sender, EventArgs e)
        {
            panel9.BackColor = Color.Black;
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            panel10.BackColor = Color.Red;
            if (Table_book("table10"))
            {
                MessageBox.Show("Alredy booked.Try another one!");
            }
            else
            {
                Table_booking("table10");
            }
        }

        private void panel10_MouseHover(object sender, EventArgs e)
        {
            panel10.BackColor = Color.MediumSpringGreen;
        }

        private void panel10_MouseLeave(object sender, EventArgs e)
        {
            panel10.BackColor = Color.Black;
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            panel11.BackColor = Color.Red;
            if (Table_book("table11"))
            {
                MessageBox.Show("Alredy booked.Try another one!");
            }
            else
            {
                Table_booking("table11");
            }
        }

        private void panel11_MouseHover(object sender, EventArgs e)
        {
            panel11.BackColor = Color.MediumSpringGreen;
        }

        private void panel11_MouseLeave(object sender, EventArgs e)
        {
            panel11.BackColor = Color.Black;
        }

        private void panel12_Click(object sender, EventArgs e)
        {
            panel12.BackColor = Color.Red;
            if (Table_book("table12"))
            {
                MessageBox.Show("Alredy booked.Try another one!");
            }
            else
            {
                Table_booking("table12");
            }
        }

        private void panel12_MouseHover(object sender, EventArgs e)
        {
            panel12.BackColor = Color.MediumSpringGreen;
        }

        private void panel12_MouseLeave(object sender, EventArgs e)
        {
            panel12.BackColor = Color.Black;
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            panel13.BackColor = Color.Red;
            if (Table_book("table13"))
            {
                MessageBox.Show("Alredy booked.Try another one!");
            }
            else
            {
                Table_booking("table13");
            }
        }

        private void panel13_MouseHover(object sender, EventArgs e)
        {
            panel13.BackColor = Color.MediumSpringGreen;
        }

        private void panel13_MouseLeave(object sender, EventArgs e)
        {
            panel13.BackColor = Color.Black;
        }

        private void panel14_Click(object sender, EventArgs e)
        {
            panel14.BackColor = Color.Red;
            if (Table_book("table14"))
            {
                MessageBox.Show("Alredy booked.Try another one!");
            }
            else
            {
                Table_booking("table14");
            }
        }

        private void panel14_MouseHover(object sender, EventArgs e)
        {
            panel14.BackColor = Color.MediumSpringGreen;
        }

        private void panel14_MouseLeave(object sender, EventArgs e)
        {
            panel14.BackColor = Color.Black;
        }

        private void panel15_Click(object sender, EventArgs e)
        {
            panel15.BackColor = Color.Red;
            if (Table_book("table15"))
            {
                MessageBox.Show("Alredy booked.Try another one!");
            }
            else
            {
                Table_booking("table15");
            }
        }

        private void panel15_MouseHover(object sender, EventArgs e)
        {
            panel15.BackColor = Color.MediumSpringGreen;
        }

        private void panel15_MouseLeave(object sender, EventArgs e)
        {
            panel15.BackColor = Color.Black;
        }

        private void panel16_Click(object sender, EventArgs e)
        {
            panel16.BackColor = Color.Red;
            if (Table_book("table16"))
            {
                MessageBox.Show("Alredy booked.Try another one!");
            }
            else
            {
                Table_booking("table16");
            }
        }

        private void panel16_MouseHover(object sender, EventArgs e)
        {
            panel16.BackColor = Color.MediumSpringGreen;
        }

        private void panel16_MouseLeave(object sender, EventArgs e)
        {
            panel16.BackColor = Color.Black;
        }

        private void panel17_Click(object sender, EventArgs e)
        {
            panel17.BackColor = Color.Red;
            if (Table_book("table17"))
            {
                MessageBox.Show("Alredy booked.Try another one!");
            }
            else
            {
                Table_booking("table17");
            }
        }

        private void panel17_MouseHover(object sender, EventArgs e)
        {
            panel17.BackColor = Color.MediumSpringGreen;
        }

        private void panel17_MouseLeave(object sender, EventArgs e)
        {
            panel17.BackColor = Color.Black;
        }

        private void panel18_Click(object sender, EventArgs e)
        {
            panel18.BackColor = Color.Red;
            if (Table_book("table18"))
            {
                MessageBox.Show("Alredy booked.Try another one!");
            }
            else
            {
                Table_booking("table18");
            }
        }

        private void panel18_MouseHover(object sender, EventArgs e)
        {
            panel18.BackColor = Color.MediumSpringGreen;
        }

        private void panel18_MouseLeave(object sender, EventArgs e)
        {
            panel18.BackColor = Color.Black;
        }

        private void BookingCheck_Tick(object sender, EventArgs e)
        {
            if (Table_book("table1")){
                panel1.BackColor = Color.Red;
            }else{
                panel1.BackColor = Color.Black;
            }
            if (Table_book("table2"))
            {
                panel2.BackColor = Color.Red;
            }
            else
            {
                panel2.BackColor = Color.Black;
            }
            if (Table_book("table3"))
            {
                panel3.BackColor = Color.Red;
            }
            else
            {
                panel3.BackColor = Color.Black;
            }
            if (Table_book("table4"))
            {
                panel4.BackColor = Color.Red;
            }
            else
            {
                panel4.BackColor = Color.Black;
            }
            if (Table_book("table5"))
            {
                panel5.BackColor = Color.Red;
            }
            else
            {
                panel5.BackColor = Color.Black;
            }
            if (Table_book("table6"))
            {
                panel6.BackColor = Color.Red;
            }
            else
            {
                panel6.BackColor = Color.Black;
            }
            if (Table_book("table7"))
            {
                panel7.BackColor = Color.Red;
            }
            else
            {
                panel7.BackColor = Color.Black;
            }
            if (Table_book("table8"))
            {
                panel8.BackColor = Color.Red;
            }
            else
            {
                panel8.BackColor = Color.Black;
            }
            if (Table_book("table9"))
            {
                panel9.BackColor = Color.Red;
            }
            else
            {
                panel9.BackColor = Color.Black;
            }
            if (Table_book("table10"))
            {
                panel10.BackColor = Color.Red;
            }
            else
            {
                panel10.BackColor = Color.Black;
            }
            if (Table_book("table11"))
            {
                panel11.BackColor = Color.Red;
            }
            else
            {
                panel11.BackColor = Color.Black;
            }
            if (Table_book("table12"))
            {
                panel12.BackColor = Color.Red;
            }
            else
            {
                panel12.BackColor = Color.Black;
            }
            if (Table_book("table13"))
            {
                panel13.BackColor = Color.Red;
            }
            else
            {
                panel13.BackColor = Color.Black;
            }
            if (Table_book("table14"))
            {
                panel14.BackColor = Color.Red;
            }
            else
            {
                panel14.BackColor = Color.Black;
            }
            if (Table_book("table15"))
            {
                panel15.BackColor = Color.Red;
            }
            else
            {
                panel15.BackColor = Color.Black;
            }
            if (Table_book("table16"))
            {
                panel16.BackColor = Color.Red;
            }
            else
            {
                panel16.BackColor = Color.Black;
            }
            if (Table_book("table17"))
            {
                panel17.BackColor = Color.Red;
            }
            else
            {
                panel17.BackColor = Color.Black;
            }
            if (Table_book("table18"))
            {
                panel18.BackColor = Color.Red;
            }
            else
            {
                panel18.BackColor = Color.Black;
            }
        }

        private bool Table_book(string p)
        {
           // sendValueOnTable(p);
            string connStr = "server=localhost;user=root;database=ra;password=;";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql = "SELECT * FROM tablebookingstatus where tableNo='" + p + "' and Status='1'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    return true;
                }
            }
            return false;
        }
        private  void Table_booking(string p)
        {
            if (Seat_OR_Not()==0)
            {
                string connStr = "server=localhost;user=root;database=ra;password=;";
                string sql = "UPDATE tablebookingstatus SET Status='1' where tableNo='" + p + "' ";
                
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connStr))
                    {
                        conn.Open();
                        using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.ExecuteNonQuery();
                            sendValueForTabling_booking(p);
                        }
                        conn.Close();
                    }
                    //MessageBox.Show("Table="+p +"| name="+getEmail());
                    sql = "UPDATE tablebookingstatus SET userID='" + getEmail() + "' where tableNo='" + p + "' ";
                    using (MySqlConnection con = new MySqlConnection(connStr))
                    {
                        con.Open();
                        using (MySqlCommand cmd2 = new MySqlCommand(sql, con))
                        {
                            cmd2.ExecuteNonQuery();
                        }
                        con.Close();
                    }
                    
                   // MessageBox.Show("Table booked successfully...");
                    frmIndex n = new frmIndex();
                    n.Show();
                    closeCount = 0;
                    BookingCheck.Stop();
                    closeFlag = true;
                    frmClose.Enabled = true;
                    frmClose.Start();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: "+e);
                    BookingCheck.Stop();
                }
            }
            else {
                MessageBox.Show("You already booked");
            }
        }
        private void sendValueForTabling_booking(string table)
        {
            try
            {
                FileReadWrite frw = new FileReadWrite();
                // 1 means table booked
                string str = frw.getEmailValueString() + "1$" + DateTime.Now.ToString("HH:mm:ss tt")+table+"$0";
                frw.putEmailValueString(str);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This color defined that the table is already booked!");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("This color defined that the table is available now!");
        }
        public string getEmail()
        {
            try
            {
                FileReadWrite frw = new FileReadWrite();
                string[] str = frw.getEmailValueString().Split('$');
                return str[3];

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return "error";

            }
        }
        
    }
}
