namespace Restaurant_Application
{
    partial class frmEmpty_One
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrder));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlRightHide = new System.Windows.Forms.Panel();
            this.topPnlEffect = new System.Windows.Forms.Timer(this.components);
            this.frmOpacity = new System.Windows.Forms.Timer(this.components);
            this.frmClose = new System.Windows.Forms.Timer(this.components);
            this.Exit = new System.Windows.Forms.ToolTip(this.components);
            this.pnlPower = new System.Windows.Forms.Panel();
            this.picPower = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlRightCenter = new System.Windows.Forms.Panel();
            this.pnlLock = new System.Windows.Forms.Panel();
            this.picLock = new System.Windows.Forms.PictureBox();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.SliderClose = new System.Windows.Forms.Timer(this.components);
            this.Home = new System.Windows.Forms.ToolTip(this.components);
            this.Locked = new System.Windows.Forms.ToolTip(this.components);
            this.copyright = new System.Windows.Forms.Label();
            this.BookingCheck = new System.Windows.Forms.Timer(this.components);
            this.pnlPower.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPower)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlRightCenter.SuspendLayout();
            this.pnlLock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLock)).BeginInit();
            this.pnlHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.pnlMain.Location = new System.Drawing.Point(1, 47);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(709, 443);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlRightHide
            // 
            this.pnlRightHide.BackColor = System.Drawing.Color.Black;
            this.pnlRightHide.Location = new System.Drawing.Point(1006, 0);
            this.pnlRightHide.Name = "pnlRightHide";
            this.pnlRightHide.Size = new System.Drawing.Size(16, 648);
            this.pnlRightHide.TabIndex = 2;
            this.pnlRightHide.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // topPnlEffect
            // 
            this.topPnlEffect.Interval = 5;
            this.topPnlEffect.Tick += new System.EventHandler(this.topPnlEffect_Tick);
            // 
            // frmOpacity
            // 
            this.frmOpacity.Tick += new System.EventHandler(this.frmOpacity_Tick);
            // 
            // frmClose
            // 
            this.frmClose.Interval = 1000;
            this.frmClose.Tick += new System.EventHandler(this.frmClose_Tick);
            // 
            // pnlPower
            // 
            this.pnlPower.BackColor = System.Drawing.Color.Black;
            this.pnlPower.Controls.Add(this.picPower);
            this.pnlPower.Location = new System.Drawing.Point(3, 393);
            this.pnlPower.Name = "pnlPower";
            this.pnlPower.Size = new System.Drawing.Size(69, 74);
            this.pnlPower.TabIndex = 1;
            this.Exit.SetToolTip(this.pnlPower, "Exit");
            this.pnlPower.Click += new System.EventHandler(this.picPower_Click);
            this.pnlPower.MouseLeave += new System.EventHandler(this.picPower_MouseLeave);
            this.pnlPower.MouseHover += new System.EventHandler(this.picPower_MouseHover);
            // 
            // picPower
            // 
            this.picPower.BackColor = System.Drawing.Color.Transparent;
            this.picPower.Image = ((System.Drawing.Image)(resources.GetObject("picPower.Image")));
            this.picPower.Location = new System.Drawing.Point(4, 11);
            this.picPower.Name = "picPower";
            this.picPower.Size = new System.Drawing.Size(61, 53);
            this.picPower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPower.TabIndex = 0;
            this.picPower.TabStop = false;
            this.Exit.SetToolTip(this.picPower, "Exit");
            this.picPower.Click += new System.EventHandler(this.picPower_Click);
            this.picPower.MouseLeave += new System.EventHandler(this.picPower_MouseLeave);
            this.picPower.MouseHover += new System.EventHandler(this.picPower_MouseHover);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.pnlTop.Controls.Add(this.pnlRightCenter);
            this.pnlTop.Location = new System.Drawing.Point(945, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(75, 648);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.Visible = false;
            // 
            // pnlRightCenter
            // 
            this.pnlRightCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.pnlRightCenter.Controls.Add(this.pnlLock);
            this.pnlRightCenter.Controls.Add(this.pnlPower);
            this.pnlRightCenter.Controls.Add(this.pnlHome);
            this.pnlRightCenter.Location = new System.Drawing.Point(0, 92);
            this.pnlRightCenter.Name = "pnlRightCenter";
            this.pnlRightCenter.Size = new System.Drawing.Size(75, 479);
            this.pnlRightCenter.TabIndex = 4;
            // 
            // pnlLock
            // 
            this.pnlLock.BackColor = System.Drawing.Color.Black;
            this.pnlLock.Controls.Add(this.picLock);
            this.pnlLock.Location = new System.Drawing.Point(3, 3);
            this.pnlLock.Name = "pnlLock";
            this.pnlLock.Size = new System.Drawing.Size(69, 74);
            this.pnlLock.TabIndex = 3;
            this.Locked.SetToolTip(this.pnlLock, "Locked");
            this.pnlLock.Click += new System.EventHandler(this.picLock_Click);
            this.pnlLock.MouseLeave += new System.EventHandler(this.picLock_MouseLeave);
            this.pnlLock.MouseHover += new System.EventHandler(this.picLock_MouseHover);
            // 
            // picLock
            // 
            this.picLock.BackColor = System.Drawing.Color.Transparent;
            this.picLock.Image = global::Restaurant_Application.Properties.Resources.White_lock;
            this.picLock.Location = new System.Drawing.Point(3, 11);
            this.picLock.Name = "picLock";
            this.picLock.Size = new System.Drawing.Size(61, 53);
            this.picLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLock.TabIndex = 4;
            this.picLock.TabStop = false;
            this.Locked.SetToolTip(this.picLock, "Locked");
            this.picLock.Click += new System.EventHandler(this.picLock_Click);
            this.picLock.MouseLeave += new System.EventHandler(this.picLock_MouseLeave);
            this.picLock.MouseHover += new System.EventHandler(this.picLock_MouseHover);
            // 
            // pnlHome
            // 
            this.pnlHome.BackColor = System.Drawing.Color.Black;
            this.pnlHome.Controls.Add(this.picHome);
            this.pnlHome.Location = new System.Drawing.Point(3, 198);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(69, 74);
            this.pnlHome.TabIndex = 2;
            this.Home.SetToolTip(this.pnlHome, "Home");
            this.pnlHome.Click += new System.EventHandler(this.picHome_Click_1);
            this.pnlHome.MouseLeave += new System.EventHandler(this.picHome_MouseLeave);
            this.pnlHome.MouseHover += new System.EventHandler(this.picHome_MouseHover);
            // 
            // picHome
            // 
            this.picHome.BackColor = System.Drawing.Color.Transparent;
            this.picHome.Image = global::Restaurant_Application.Properties.Resources.White_home;
            this.picHome.Location = new System.Drawing.Point(4, 10);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(61, 53);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHome.TabIndex = 4;
            this.picHome.TabStop = false;
            this.Home.SetToolTip(this.picHome, "Home");
            this.picHome.Click += new System.EventHandler(this.picHome_Click_1);
            this.picHome.MouseLeave += new System.EventHandler(this.picHome_MouseLeave);
            this.picHome.MouseHover += new System.EventHandler(this.picHome_MouseHover);
            // 
            // SliderClose
            // 
            this.SliderClose.Tick += new System.EventHandler(this.SliderClose_Tick);
            // 
            // copyright
            // 
            this.copyright.AutoSize = true;
            this.copyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright.Location = new System.Drawing.Point(512, 619);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(285, 29);
            this.copyright.TabIndex = 3;
            this.copyright.Text = "Developed by @ RedHex";
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1022, 648);
            this.Controls.Add(this.copyright);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlRightHide);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1022, 648);
            this.Name = "frmOrder";
            this.Text = "Index";
            this.Load += new System.EventHandler(this.frmIndex_Load);
            this.pnlPower.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPower)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlRightCenter.ResumeLayout(false);
            this.pnlLock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLock)).EndInit();
            this.pnlHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlLock;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Panel pnlPower;
        private System.Windows.Forms.PictureBox picPower;
        private System.Windows.Forms.Panel pnlRightHide;
        private System.Windows.Forms.Timer topPnlEffect;
        private System.Windows.Forms.Timer frmOpacity;
        private System.Windows.Forms.ToolTip Exit;
        private System.Windows.Forms.Timer frmClose;
        private System.Windows.Forms.Panel pnlRightCenter;
        private System.Windows.Forms.PictureBox picLock;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.Timer SliderClose;
        private System.Windows.Forms.ToolTip Home;
        private System.Windows.Forms.ToolTip Locked;
        private System.Windows.Forms.Label copyright;
        private System.Windows.Forms.Timer BookingCheck;
    }
}

