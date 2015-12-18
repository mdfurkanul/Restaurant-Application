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
using System.Drawing.Printing;

namespace Restaurant_Application
{
    public partial class frmOrder : Form
    {
        string connStr = "server=localhost;user=root;database=ra;password=;";
        bool closeFlag = false;
        int closeCount = 0;
        bool SliderOpen = false;
        int newWidth = 1;
        int ScreenHeight = 0;
        int ScreenWidth = 0;
        int TT = 0;
        public frmOrder()
        {
            InitializeComponent();
            if (!getUserWho().Equals("Empty"))
            {
                string query = "SELECT * FROM food_order where who='" + getUserWho() + "';";

                using (MySqlConnection con = new MySqlConnection(connStr))
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        using (MySqlDataReader rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                listBox1.Items.Add("  " + food_name(rdr.GetString("food_id")));
                                int Quantity = Convert.ToInt32(rdr.GetString("quantity"));
                                int Total = Convert.ToInt32(rdr.GetString("price"));
                                TT += Total;
                                string perPrice = String.Format("{0:n}", Total / Quantity);
                                string strr = "  -- " + Quantity + " x " + String.Format("{0:n}", perPrice);
                                int len = strr.Length;
                                listBox1.Items.Add(strr.PadRight(50 - len) + String.Format("{0:n}", Total) + "  ");
                            }
                        }
                    }
                }
            }
            else
            {
                listBox1.Items.Add("**********Empty**********".PadLeft(40));
            }
            txtPrice.Text=(String.Format("{0:n}", TT));
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

        private void ListAddTimer_Tick(object sender, EventArgs e)
        {
            if (!getUserWho().Equals("Empty"))
            {
                string query = "SELECT * FROM food_order where who='" + getUserWho() + "';";
                using (MySqlConnection con = new MySqlConnection(connStr))
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        using (MySqlDataReader rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                listBox1.Items.Add(food_name(rdr.GetString("food_id")));
                                int Quantity = Convert.ToInt32(rdr.GetString("quantity"));
                                int Total = Convert.ToInt32(rdr.GetString("price"));
                                string perPrice = String.Format("{0:n}", Total / Quantity);
                                listBox1.Items.Add("-- " + Quantity + " x " + String.Format("{0:n}", perPrice) + " ".PadRight(110) + String.Format("{0:n}", Total));
                            }
                        }
                    }
                }
            }
            else {
                listBox1.Items.Add("**********Empty**********".PadLeft(40));
            }
        }
        private string food_name(string pp)
        {
            string query = "SELECT * FROM menu where Id='" +pp+ "';";
            using (MySqlConnection con = new MySqlConnection(connStr))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            return rdr.GetString("Name");
                        }
                    }
                }
                con.Close();
            }
            return "**********Empty**********";
        }
        public string getUserWho()
        {
            try
            {
                FileReadWrite frw = new FileReadWrite();
                string[] str = frw.getEmailValueString().Split('$');
                //str[3];
                return str[3];// "20:08:05 PMtable18";

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return "Empty";

            }
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            int quantityValue = 0;
            int priceValue = 0;
            if (!(txtCash.Text).Equals(""))
            {
                quantityValue = Convert.ToInt32(txtCash.Text);
            }
            string[] str = txtPrice.Text.Split(':');
            txtChange.Text =String.Format("{0:n}",(quantityValue-TT));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure want to exit and take a receipt?", "Confirmation Message",
                                MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                string connStr = "server=localhost;user=root;database=ra;password=;";
                string sql = "UPDATE waiting_quque SET status='2' where id='" + getUser() + "' ";

                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connStr))
                    {
                        conn.Open();
                        using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                        conn.Close();
                    }
                }
                catch (Exception exx) {
                    MessageBox.Show(""+exx);
                }
                closeFlag = true;
                pnlLock.BackColor = Color.FromArgb(0, 190, 240);
                frmClose.Enabled = true;
                frmClose.Start();
                SliderClose.Stop();
                frmLogin n = new frmLogin();
                n.Show();
                PrintDialog printDialog = new PrintDialog();
                PrintDocument printDocument = new PrintDocument();
                printDialog.Document = printDocument; //add the document to the dialog box...        
                printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt); //add an event handler that will do the printing
                DialogResult result = printDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    printDocument.Print();
                }
                
            }
            
        }

        public void CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;

            Font font = new Font("Courier New", 14); //must use a mono spaced font as the spaces need to line up

            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 40;
            string date = DateTime.Now.ToString("dd/MM/yy");
            string time = DateTime.Now.ToString("HH:mm:ss tt");
            graphic.DrawString("********Restaurant Application********", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);
            offset = offset-12; //make the spacing consistent
            graphic.DrawString("                H#20, R#17,Uttara-10,1230", new Font("Courier New", 12), new SolidBrush(Color.Black), startX, startY + offset);
            offset += 52;
            graphic.DrawString("ID: " + getUnq().PadRight(30) + "Table: " + getTable(), font, new SolidBrush(Color.Black), startX, startY + offset);
            offset += 20;
            graphic.DrawString("Time: " + time.PadRight(28) + "Date: " + date, font, new SolidBrush(Color.Black), startX, startY + offset);
            
            offset += 20;
            graphic.DrawString("Delay : " + getDelay(), font, new SolidBrush(Color.Black), startX, startY + offset);
            
            offset = offset + 20; //make the spacing consistent
            graphic.DrawString("----------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            string top = "Item Name".PadRight(35) + "Total Price";
            offset += 20;
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + 20; //make the spacing consistent
            graphic.DrawString("----------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5; //make the spacing consistent

            float totalprice = 0.00f;

            foreach (string item in listBox1.Items)
            {
                    graphic.DrawString(item, font, new SolidBrush(Color.Black), startX, startY + offset);
                    offset = offset + (int)fontHeight + 5; //make the spacing consistent
            }

           // change = (cash - totalprice);

            //when we have drawn all of the items add the total

            offset = offset + 20; //make some room so that the total stands out.
            graphic.DrawString("----------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 20;
            graphic.DrawString("Total to pay ".PadRight(40) + String.Format("{0:n}", TT), new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            string Cash = String.Format("{0:n}", Convert.ToDouble(txtCash.Text));
            offset = offset + 30; //make some room so that the total stands out.
            graphic.DrawString("CASH ".PadRight(40-Cash.Length) + Cash, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 20;
            string Change = String.Format("{0:n}", txtChange.Text);
            graphic.DrawString("CHANGE ".PadRight(40-Change.Length) + Change, font, new SolidBrush(Color.Black), startX, startY + offset);

            //graphic.DrawString("", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 130; //make some room so that the total stands out.
            graphic.DrawString("         Thank-you for your choice,", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 20;
            graphic.DrawString("           please come back soon!", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 20;
            graphic.DrawString("             Powered By RedHex.", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 30;
            Barcode myBarcode = new Barcode();
            Bitmap bmp = myBarcode.Create(150, 50, 130, getUnq());
            graphic.DrawImage(bmp, new Rectangle(startX, startY + offset, bmp.Width, bmp.Height));
            

        }
        public string getTable()
        {
            try
            {
                FileReadWrite frw = new FileReadWrite();
                string[] str = frw.getEmailValueString().Split('$');
                // MessageBox.Show("3=== " + str[3]);
                 return str[3].Substring(16, str[3].Length-16);

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return "error";

            }
        }
        private string getDelay()
        {
            string query = "SELECT * FROM waiting_quque where status='2' and id='" + getUser() + "';";
            using (MySqlConnection con = new MySqlConnection(connStr))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            return rdr.GetString("delay");
                        }
                    }
                }
                con.Close();
            }
            return "00:00:00";
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
        public string getUnq()
        {
            try
            {
                FileReadWrite frw = new FileReadWrite();
                string[] str = frw.getEmailValueString().Split('$');
                // MessageBox.Show("3=== " + str[4]);
                string tmp = str[3];
                string check = "";
                for (int i = 0; i < tmp.Length;i++ ) {
                    if (tmp[i] == ' ')
                    {
                        check += "-";
                    }
                    else if (tmp[i] == ':')
                    {
                    check += "$";
                    }
                    else {
                        check += tmp[i];
                    }
                }
                return check;

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return "error";

            }
        }


    }
}
