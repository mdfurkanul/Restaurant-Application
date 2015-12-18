namespace Restaurant_Application
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.errMsg = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlGuest = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.passER = new System.Windows.Forms.Label();
            this.unameER = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pnlBtnForgot = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lostEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.pnlExit = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.exitToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.forgotUnameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlNewUser = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.NewUserToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.frmClose = new System.Windows.Forms.Timer(this.components);
            this.frmLoginOpacity = new System.Windows.Forms.Timer(this.components);
            this.pnlMain.SuspendLayout();
            this.pnlGuest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnlBtnForgot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlExit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlNewUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(240)))));
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMain.Controls.Add(this.errMsg);
            this.pnlMain.Controls.Add(this.Type);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.pnlGuest);
            this.pnlMain.Controls.Add(this.passER);
            this.pnlMain.Controls.Add(this.unameER);
            this.pnlMain.Controls.Add(this.pnlLogin);
            this.pnlMain.Controls.Add(this.pictureBox4);
            this.pnlMain.Controls.Add(this.pnlBtnForgot);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.Pass);
            this.pnlMain.Controls.Add(this.Email);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.shapeContainer1);
            this.pnlMain.Location = new System.Drawing.Point(23, 175);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(653, 378);
            this.pnlMain.TabIndex = 1;
            // 
            // errMsg
            // 
            this.errMsg.AutoSize = true;
            this.errMsg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsg.ForeColor = System.Drawing.Color.BlueViolet;
            this.errMsg.Location = new System.Drawing.Point(375, 219);
            this.errMsg.Name = "errMsg";
            this.errMsg.Size = new System.Drawing.Size(0, 21);
            this.errMsg.TabIndex = 19;
            // 
            // Type
            // 
            this.Type.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.FormattingEnabled = true;
            this.Type.Items.AddRange(new object[] {
            "Member",
            "Chef"});
            this.Type.Location = new System.Drawing.Point(141, 178);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(172, 33);
            this.Type.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Type";
            // 
            // pnlGuest
            // 
            this.pnlGuest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGuest.Controls.Add(this.label4);
            this.pnlGuest.Controls.Add(this.pictureBox6);
            this.pnlGuest.Location = new System.Drawing.Point(141, 296);
            this.pnlGuest.Name = "pnlGuest";
            this.pnlGuest.Size = new System.Drawing.Size(384, 60);
            this.pnlGuest.TabIndex = 16;
            this.pnlGuest.Click += new System.EventHandler(this.btnGuestLogin);
            this.pnlGuest.MouseLeave += new System.EventHandler(this.btnGuestLogin_leave);
            this.pnlGuest.MouseHover += new System.EventHandler(this.btnGuestLogin_hover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(146, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 39);
            this.label4.TabIndex = 18;
            this.label4.Text = "Login as Guest";
            this.label4.Click += new System.EventHandler(this.btnGuestLogin);
            this.label4.MouseLeave += new System.EventHandler(this.btnGuestLogin_leave);
            this.label4.MouseHover += new System.EventHandler(this.btnGuestLogin_hover);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.DarkCyan;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 60);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 17;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.btnGuestLogin);
            this.pictureBox6.MouseLeave += new System.EventHandler(this.btnGuestLogin_leave);
            this.pictureBox6.MouseHover += new System.EventHandler(this.btnGuestLogin_hover);
            // 
            // passER
            // 
            this.passER.AutoSize = true;
            this.passER.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passER.ForeColor = System.Drawing.Color.Red;
            this.passER.Location = new System.Drawing.Point(319, 165);
            this.passER.Name = "passER";
            this.passER.Size = new System.Drawing.Size(0, 17);
            this.passER.TabIndex = 15;
            // 
            // unameER
            // 
            this.unameER.AutoSize = true;
            this.unameER.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unameER.ForeColor = System.Drawing.Color.Red;
            this.unameER.Location = new System.Drawing.Point(318, 123);
            this.unameER.Name = "unameER";
            this.unameER.Size = new System.Drawing.Size(0, 17);
            this.unameER.TabIndex = 14;
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.pictureBox5);
            this.pnlLogin.Location = new System.Drawing.Point(141, 219);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(175, 55);
            this.pnlLogin.TabIndex = 13;
            this.pnlLogin.Click += new System.EventHandler(this.btnLogin);
            this.pnlLogin.MouseLeave += new System.EventHandler(this.btnLogin_leave);
            this.pnlLogin.MouseHover += new System.EventHandler(this.btnLogin_hover);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(13, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(160, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.btnLogin);
            this.pictureBox5.MouseLeave += new System.EventHandler(this.btnLogin_leave);
            this.pictureBox5.MouseHover += new System.EventHandler(this.btnLogin_hover);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(176, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(331, 89);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pnlBtnForgot
            // 
            this.pnlBtnForgot.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlBtnForgot.Controls.Add(this.pictureBox2);
            this.pnlBtnForgot.Location = new System.Drawing.Point(589, 156);
            this.pnlBtnForgot.Name = "pnlBtnForgot";
            this.pnlBtnForgot.Size = new System.Drawing.Size(44, 37);
            this.pnlBtnForgot.TabIndex = 11;
            this.pnlBtnForgot.Click += new System.EventHandler(this.btnForgot_click);
            this.pnlBtnForgot.MouseLeave += new System.EventHandler(this.btnForgot_leave);
            this.pnlBtnForgot.MouseHover += new System.EventHandler(this.btnForgot_hover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.btnForgot_leave);
            this.pictureBox2.MouseHover += new System.EventHandler(this.btnForgot_hover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lostEmail);
            this.panel1.Location = new System.Drawing.Point(365, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 37);
            this.panel1.TabIndex = 9;
            // 
            // lostEmail
            // 
            this.lostEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lostEmail.Location = new System.Drawing.Point(0, 2);
            this.lostEmail.Name = "lostEmail";
            this.lostEmail.Size = new System.Drawing.Size(222, 33);
            this.lostEmail.TabIndex = 7;
            this.forgotUnameToolTip.SetToolTip(this.lostEmail, "Enter Email");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(359, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Forgot password";
            // 
            // Pass
            // 
            this.Pass.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.Location = new System.Drawing.Point(141, 136);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(173, 33);
            this.Pass.TabIndex = 4;
            this.Pass.UseSystemPasswordChar = true;
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(141, 94);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(173, 33);
            this.Email.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(649, 374);
            this.shapeContainer1.TabIndex = 12;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 345;
            this.lineShape1.X2 = 345;
            this.lineShape1.Y1 = 80;
            this.lineShape1.Y2 = 273;
            // 
            // pnlExit
            // 
            this.pnlExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.pnlExit.Controls.Add(this.pictureBox1);
            this.pnlExit.Location = new System.Drawing.Point(860, 40);
            this.pnlExit.Name = "pnlExit";
            this.pnlExit.Size = new System.Drawing.Size(78, 65);
            this.pnlExit.TabIndex = 1;
            this.exitToolTip.SetToolTip(this.pnlExit, "Exit");
            this.pnlExit.Click += new System.EventHandler(this.btnExit);
            this.pnlExit.MouseLeave += new System.EventHandler(this.Exit_leave);
            this.pnlExit.MouseHover += new System.EventHandler(this.Exit_hover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.exitToolTip.SetToolTip(this.pictureBox1, "Exit");
            this.pictureBox1.Click += new System.EventHandler(this.btnExit);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.Exit_leave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.Exit_hover);
            // 
            // loginToolTip
            // 
            this.loginToolTip.BackColor = System.Drawing.Color.Transparent;
            // 
            // exitToolTip
            // 
            this.exitToolTip.BackColor = System.Drawing.Color.DeepSkyBlue;
            // 
            // pnlNewUser
            // 
            this.pnlNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.pnlNewUser.Controls.Add(this.pictureBox3);
            this.pnlNewUser.Location = new System.Drawing.Point(779, 40);
            this.pnlNewUser.Name = "pnlNewUser";
            this.pnlNewUser.Size = new System.Drawing.Size(78, 65);
            this.pnlNewUser.TabIndex = 2;
            this.NewUserToolTip.SetToolTip(this.pnlNewUser, "Create account");
            this.pnlNewUser.Click += new System.EventHandler(this.btnNewUser);
            this.pnlNewUser.MouseLeave += new System.EventHandler(this.btnNewUser_Leave);
            this.pnlNewUser.MouseHover += new System.EventHandler(this.btnNewUser_Hover);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(23, 16);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.NewUserToolTip.SetToolTip(this.pictureBox3, "Create account");
            this.pictureBox3.Click += new System.EventHandler(this.btnNewUser);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.btnNewUser_Leave);
            this.pictureBox3.MouseHover += new System.EventHandler(this.btnNewUser_Hover);
            // 
            // frmClose
            // 
            this.frmClose.Enabled = true;
            this.frmClose.Interval = 1000;
            this.frmClose.Tick += new System.EventHandler(this.frmClose_Tick);
            // 
            // frmLoginOpacity
            // 
            this.frmLoginOpacity.Tick += new System.EventHandler(this.frmLoginOpacity_Tick);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1022, 648);
            this.Controls.Add(this.pnlNewUser);
            this.Controls.Add(this.pnlExit);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1022, 648);
            this.Name = "frmLogin";
            this.Text = "Index";
            this.Load += new System.EventHandler(this.frmIndex_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlGuest.ResumeLayout(false);
            this.pnlGuest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnlBtnForgot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlExit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlNewUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox lostEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlBtnForgot;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip loginToolTip;
        private System.Windows.Forms.ToolTip forgotUnameToolTip;
        private System.Windows.Forms.ToolTip exitToolTip;
        private System.Windows.Forms.Panel pnlNewUser;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolTip NewUserToolTip;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel pnlGuest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label passER;
        private System.Windows.Forms.Label unameER;
        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label errMsg;
        private System.Windows.Forms.Timer frmClose;
        private System.Windows.Forms.Timer frmLoginOpacity;
    }
}

