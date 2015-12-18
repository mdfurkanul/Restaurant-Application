using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using System.IO;
using System.Web;
namespace Restaurant_Application
{
    public partial class frmIndex : Form
    {
        bool closeFlag = false;
        int closeCount = 0;
        bool SliderOpen = false;
        int newWidth = 1;
        int ScreenHeight = 0;
        int ScreenWidth = 0;
        int ColorChangeCounter = 0;
        string Temperature;
        string Condition;
        string TFHigh;
        string TFLow;
        public frmIndex()
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
            ColorChange.Enabled = true;
            ColorChange.Start();
            tmTime.Enabled = true;
            tmTime.Start();
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                getWeather();
            }
            
            tmWeather.Enabled = true;
            tmWeather.Start();
        }
        private void getWeather()
        {
            try {
                string query = string.Format("http://weather.yahooapis.com/forecastrss?w=1915035");
                XmlDocument Weather = new XmlDocument();
                Weather.Load(query);
                XmlNamespaceManager manager = new XmlNamespaceManager(Weather.NameTable);
                manager.AddNamespace("yweather", "http://xml.weather.yahoo.com/ns/rss/1.0");
                XmlNode channel = Weather.SelectSingleNode("rss").SelectSingleNode("channel");
                XmlNodeList nodes = Weather.SelectNodes("/rss/channel/item/yweather:forecast", manager);

                Temperature = channel.SelectSingleNode("item").SelectSingleNode("yweather:condition", manager).Attributes["temp"].Value;

                Condition = channel.SelectSingleNode("item").SelectSingleNode("yweather:condition", manager).Attributes["text"].Value;

                TFHigh = channel.SelectSingleNode("item").SelectSingleNode("yweather:forecast", manager).Attributes["high"].Value;

                TFLow = channel.SelectSingleNode("item").SelectSingleNode("yweather:forecast", manager).Attributes["low"].Value;
                lbTem.Text = Temperature;
                lbStatus.Text = Condition;
                lbDown.Text = TFLow;
                lbUp.Text = TFHigh;
            }catch(Exception e){
                Console.WriteLine(""+e);
            }

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
            copyright.Location = new Point(lX, lY-100);
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
            StopTimerAll();
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

        private void ColorChange_Tick(object sender, EventArgs e)
        {
            if (ColorChangeCounter == 0)
            {
                pnlMenu.BackColor = Color.Fuchsia;
                pnlFavurit.BackColor = Color.FromArgb(240,0,0);
                pnlDiscount.BackColor = Color.DarkOrange;
                pnlTime.BackColor = Color.Purple;
                pnlContact.BackColor = Color.RoyalBlue;
                pnlMostPopular.BackColor = Color.BlueViolet;
                pnlTable.BackColor = Color.DeepPink;
                pnlWeather.BackColor = Color.OrangeRed;
                pnlDate.BackColor = Color.LimeGreen;
                ColorChangeCounter = 1;
            }
            else if (ColorChangeCounter == 1)
            {
                pnlMenu.BackColor = Color.RoyalBlue;
                pnlFavurit.BackColor = Color.BlueViolet;
                pnlDiscount.BackColor = Color.DeepPink;
                pnlTime.BackColor = Color.OrangeRed;
                pnlContact.BackColor = Color.Fuchsia;
                pnlMostPopular.BackColor = Color.FromArgb(240,0,0);
                pnlTable.BackColor = Color.DarkOrange;
                pnlWeather.BackColor = Color.Purple;
                pnlDate.BackColor = Color.DodgerBlue;
                ColorChangeCounter = 2;
            }
            else if (ColorChangeCounter == 2)
            {
                pnlMenu.BackColor = Color.OrangeRed;
                pnlFavurit.BackColor = Color.DarkOrange;
                pnlDiscount.BackColor = Color.LimeGreen;
                pnlTime.BackColor = Color.FromArgb(240,0,0);
                pnlContact.BackColor = Color.DodgerBlue;
                pnlMostPopular.BackColor = Color.Purple;
                pnlTable.BackColor = Color.Fuchsia;
                pnlWeather.BackColor = Color.DeepPink;
                pnlDate.BackColor = Color.MediumOrchid;
                ColorChangeCounter = 3;
            }
            else if (ColorChangeCounter == 3)
            {
                pnlMenu.BackColor = Color.FromArgb(240,0,0);
                pnlFavurit.BackColor = Color.Purple;
                pnlDiscount.BackColor = Color.MediumOrchid;
                pnlTime.BackColor = Color.Fuchsia;
                pnlContact.BackColor = Color.BlueViolet;
                pnlMostPopular.BackColor = Color.DeepPink;
                pnlTable.BackColor = Color.DodgerBlue;
                pnlWeather.BackColor = Color.LimeGreen;
                pnlDate.BackColor = Color.Crimson;
                ColorChangeCounter = 4;
            }
            else if (ColorChangeCounter == 4)
            {
                pnlMenu.BackColor = Color.DeepPink;
                pnlFavurit.BackColor = Color.Fuchsia;
                pnlDiscount.BackColor = Color.FromArgb(240,0,0);
                pnlTime.BackColor = Color.RoyalBlue;
                pnlContact.BackColor = Color.Purple;
                pnlMostPopular.BackColor = Color.Orange;
                pnlTable.BackColor = Color.BlueViolet;
                pnlWeather.BackColor = Color.DodgerBlue;
                pnlDate.BackColor = Color.DarkOrange;
                ColorChangeCounter = 5;
            }
            else if (ColorChangeCounter == 5)
            {
                pnlMenu.BackColor = Color.LimeGreen;
                pnlFavurit.BackColor = Color.OrangeRed;
                pnlDiscount.BackColor = Color.DodgerBlue;
                pnlTime.BackColor = Color.Crimson;
                pnlContact.BackColor = Color.DeepPink;
                pnlMostPopular.BackColor = Color.Fuchsia;
                pnlTable.BackColor = Color.RoyalBlue;
                pnlWeather.BackColor = Color.FromArgb(240,0,0);
                pnlDate.BackColor = Color.BlueViolet;
                ColorChangeCounter = 0;
            }
        }

        private void pnlMenu_MouseHover(object sender, EventArgs e)
        {
            pnlMenu.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pnlMenu_MouseLeave(object sender, EventArgs e)
        {
            pnlMenu.BorderStyle = BorderStyle.None;
        }

        private void pnlMenu_Click(object sender, EventArgs e)
        {
            pnlTable.BackColor = Color.MediumSpringGreen;
            StopTimerAll();
            frmMenu n = new frmMenu();
            n.Show();
            closeCount = 0;
            closeFlag = true;
            frmClose.Enabled = true;
            frmClose.Start();
        }

        private void pnlFavurit_Click(object sender, EventArgs e)
        {
            pnlTable.BackColor = Color.MediumSpringGreen;
            if (getLogInCode()==1)
            {
                    StopTimerAll();
                    frmFavourite n = new frmFavourite();
                    n.Show();
                    closeCount = 0;
                    closeFlag = true;
                    frmClose.Enabled = true;
                    frmClose.Start();
            }
            else {
                MessageBox.Show("You have to login for getting this service.");
            }
        }
        public int getLogInCode()
        {
            try
            {
                FileReadWrite frw = new FileReadWrite();
                string[] str=frw.getEmailValueString().Split('$');
                return Convert.ToInt32(str[1]);

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return 0;

            }
        }

        private void pnlFavurit_MouseHover(object sender, EventArgs e)
        {
            pnlFavurit.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pnlFavurit_MouseLeave(object sender, EventArgs e)
        {
            pnlFavurit.BorderStyle = BorderStyle.None;
        }

        private void pnlDiscount_Click(object sender, EventArgs e)
        {
            if (Seat_OR_Not() == 0)
            {
                MessageBox.Show("Please, At first select a table!");
            }
            else
            {
                if (getCountDownCode() != 0)
                {
                    pnlTable.BackColor = Color.MediumSpringGreen;
                    StopTimerAll();
                    frmOrder n = new frmOrder();
                    n.Show();
                    closeCount = 0;
                    closeFlag = true;
                    frmClose.Enabled = true;
                    frmClose.Start();
                }
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

        private void pnlDiscount_MouseHover(object sender, EventArgs e)
        {
            pnlDiscount.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pnlDiscount_MouseLeave(object sender, EventArgs e)
        {
            pnlDiscount.BorderStyle = BorderStyle.None;
        }

        private void pnlDate_MouseHover(object sender, EventArgs e)
        {
            pnlDate.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pnlDate_MouseLeave(object sender, EventArgs e)
        {
            pnlDate.BorderStyle = BorderStyle.None;
        }

        private void pnlWeather_MouseHover(object sender, EventArgs e)
        {
            pnlWeather.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pnlWeather_MouseLeave(object sender, EventArgs e)
        {
            pnlWeather.BorderStyle = BorderStyle.None;
        }

        private void pnlTable_Click(object sender, EventArgs e)
        {
            pnlTable.BackColor = Color.MediumSpringGreen;
            StopTimerAll();
            frmTable n = new frmTable();
            n.Show();
            closeCount = 0;
            closeFlag = true;
            frmClose.Enabled = true;
            frmClose.Start();
        }

        private void pnlTable_MouseHover(object sender, EventArgs e)
        {
            pnlTable.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pnlTable_MouseLeave(object sender, EventArgs e)
        {
            pnlTable.BorderStyle = BorderStyle.None;
        }

        private void pnlTime_MouseHover(object sender, EventArgs e)
        {
            pnlTime.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pnlTime_MouseLeave(object sender, EventArgs e)
        {
            pnlTime.BorderStyle = BorderStyle.None;
        }

        private void pnlContact_Click(object sender, EventArgs e)
        {
            pnlTable.BackColor = Color.MediumSpringGreen;
            StopTimerAll();
            frmContact n = new frmContact();
            n.Show();
            closeCount = 0;
            closeFlag = true;
            frmClose.Enabled = true;
            frmClose.Start();
        }

        private void pnlContact_MouseHover(object sender, EventArgs e)
        {
            pnlContact.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pnlContact_MouseLeave(object sender, EventArgs e)
        {
            pnlContact.BorderStyle = BorderStyle.None;
        }

        private void pnlMostPopular_Click(object sender, EventArgs e)
        {
            pnlTable.BackColor = Color.MediumSpringGreen;
            StopTimerAll();
            frmMostPopular n = new frmMostPopular();
            n.Show();
            closeCount = 0;
            closeFlag = true;
            frmClose.Enabled = true;
            frmClose.Start();
        }

        private void pnlMostPopular_MouseHover(object sender, EventArgs e)
        {
            pnlMostPopular.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pnlMostPopular_MouseLeave(object sender, EventArgs e)
        {
            pnlMostPopular.BorderStyle = BorderStyle.None;
        }

        private void tmTime_Tick(object sender, EventArgs e)
        {
            DateTime dt =DateTime.Now;
            lbTime.Text = string.Format("{0:hh:mm:ss}", dt);
            lbAmPm.Text = string.Format("{0: tt}", dt);

            lbDay.Text = String.Format("{0:dddd}", dt);
            lbDate.Text = String.Format("{0:d MMM, yyyy}", dt);
        }

        private void tmWeather_Tick(object sender, EventArgs e)
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                getWeather();
            }
        }
        private void StopTimerAll() {
            tmWeather.Stop();
            tmTime.Stop();
            ColorChange.Stop();
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
        
    }
}
