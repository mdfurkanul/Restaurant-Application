namespace Restaurant_Application
{
    partial class frmContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContact));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.TextBox();
            this.rst = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sub = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.snd = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.Namedaf = new System.Windows.Forms.Label();
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
            this.label2 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.pnlMain.SuspendLayout();
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
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMain.Controls.Add(this.title);
            this.pnlMain.Controls.Add(this.rst);
            this.pnlMain.Controls.Add(this.message);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.sub);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.email);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.snd);
            this.pnlMain.Controls.Add(this.name);
            this.pnlMain.Controls.Add(this.Namedaf);
            this.pnlMain.Location = new System.Drawing.Point(1, 47);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(631, 443);
            this.pnlMain.TabIndex = 1;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(240)))));
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.title.Cursor = System.Windows.Forms.Cursors.Default;
            this.title.Font = new System.Drawing.Font("Viner Hand ITC", 18F, System.Drawing.FontStyle.Bold);
            this.title.Location = new System.Drawing.Point(88, 3);
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Size = new System.Drawing.Size(443, 39);
            this.title.TabIndex = 14;
            this.title.Text = "Send your message";
            this.title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rst
            // 
            this.rst.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.rst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rst.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rst.Location = new System.Drawing.Point(393, 395);
            this.rst.Name = "rst";
            this.rst.Size = new System.Drawing.Size(75, 31);
            this.rst.TabIndex = 13;
            this.rst.Text = "Reset";
            this.rst.UseVisualStyleBackColor = false;
            this.rst.Click += new System.EventHandler(this.rst_Click);
            // 
            // message
            // 
            this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.Location = new System.Drawing.Point(70, 170);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(479, 219);
            this.message.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Message";
            // 
            // sub
            // 
            this.sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub.Location = new System.Drawing.Point(143, 96);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(397, 24);
            this.sub.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Subject";
            // 
            // snd
            // 
            this.snd.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.snd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.snd.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snd.Location = new System.Drawing.Point(474, 395);
            this.snd.Name = "snd";
            this.snd.Size = new System.Drawing.Size(75, 31);
            this.snd.TabIndex = 2;
            this.snd.Text = "Send";
            this.snd.UseVisualStyleBackColor = false;
            this.snd.Click += new System.EventHandler(this.snd_Click);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(367, 57);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(173, 24);
            this.name.TabIndex = 1;
            // 
            // Namedaf
            // 
            this.Namedaf.AutoSize = true;
            this.Namedaf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namedaf.Location = new System.Drawing.Point(311, 60);
            this.Namedaf.Name = "Namedaf";
            this.Namedaf.Size = new System.Drawing.Size(48, 18);
            this.Namedaf.TabIndex = 0;
            this.Namedaf.Text = "Name";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email";
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(123, 57);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(173, 24);
            this.email.TabIndex = 6;
            // 
            // frmContact
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
            this.Name = "frmContact";
            this.Text = "Index";
            this.Load += new System.EventHandler(this.frmIndex_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
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
        private System.Windows.Forms.Button rst;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sub;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button snd;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label Namedaf;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label2;
    }
}

