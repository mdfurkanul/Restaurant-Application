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
    public partial class frmLoading : Form
    {
        int Count= 0;
        private int closeCount=0;
        private bool closeFlag=false;
        public frmLoading()
        {
            InitializeComponent();
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
            setFullScreen();
            setMainPanelPosition();
            Loader.Enabled = true;
            Loader.Start();
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

        private void Loader_Tick(object sender, EventArgs e)
        {
            if (Count>=100)
            {
                Loader.Stop();
                frmLogin n = new frmLogin();
                n.Show();
                closeFlag = true;
                frmClose.Enabled = true;
                frmClose.Start();
            }
            else
            {
                Count+=2;
                label1.Text = "" + Count + " %";

            }

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
