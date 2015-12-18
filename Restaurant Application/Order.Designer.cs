namespace Restaurant_Application
{
    partial class frmOrder
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
            this.txtChange = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.txtChange);
            this.pnlMain.Controls.Add(this.txtPrice);
            this.pnlMain.Controls.Add(this.label10);
            this.pnlMain.Controls.Add(this.txtCash);
            this.pnlMain.Controls.Add(this.label8);
            this.pnlMain.Controls.Add(this.label7);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.button1);
            this.pnlMain.Controls.Add(this.label6);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.listBox1);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Location = new System.Drawing.Point(12, 46);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(709, 389);
            this.pnlMain.TabIndex = 1;
            // 
            // txtChange
            // 
            this.txtChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.txtChange.Cursor = System.Windows.Forms.Cursors.No;
            this.txtChange.Enabled = false;
            this.txtChange.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.txtChange.Location = new System.Drawing.Point(481, 162);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(124, 32);
            this.txtChange.TabIndex = 15;
            this.txtChange.Text = "0.00";
            this.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.No;
            this.txtPrice.Enabled = false;
            this.txtPrice.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.txtPrice.Location = new System.Drawing.Point(480, 90);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(124, 32);
            this.txtPrice.TabIndex = 14;
            this.txtPrice.Text = "0.00";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(604, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 25);
            this.label10.TabIndex = 13;
            this.label10.Text = "/- Taka";
            // 
            // txtCash
            // 
            this.txtCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.txtCash.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.txtCash.Location = new System.Drawing.Point(480, 126);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(124, 32);
            this.txtCash.TabIndex = 12;
            this.txtCash.Text = "0";
            this.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCash.TextChanged += new System.EventHandler(this.txtCash_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(604, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "/- Taka";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(354, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "Change        :";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(356, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cash           :";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Engravers MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(352, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(340, 104);
            this.button1.TabIndex = 7;
            this.button1.Text = "Take Receipt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(604, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "/- Taka";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(358, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total Price :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(223, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(11, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item Name";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.listBox1.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(5, 70);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(339, 257);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Engravers MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(687, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.TextBox txtPrice;
    }
}

